// Author:
//   Fernando F.Oliveira fernando@oliveira.eti.br
//
// Copyright (C) 2012 - Oliveira Lands
//                               
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.ComponentModel;

namespace OSGridLauncher.classes
{
    public enum EMessageCommand {
        Ignored,
        Entered,
        Left,
        MyCoordinates,
        MoveOutThere
    }

    public class messageArguments : EventArgs
    {
        public const string msgComputerEntered = "ComputerEntered";
        public const string msgComputerLeft = "ComputerLeft";

        public messageArguments(string pMessage)
        {
            this.Message = pMessage;

            msgCommand = EMessageCommand.Ignored;

            string[] msg = pMessage.Split('|');

            if (msg.Length >= 2)
            {
                ComputerName = msg[0];

                try
                {
                    if (msg[1] == "Logou")
                    {
                        msgCommand = EMessageCommand.MyCoordinates;
                    }
                    if (msg[1] == "Deslogou")
                    {
                        msgCommand = EMessageCommand.MoveOutThere;
                    }
                    if (msg[1] == msgComputerEntered)
                    {
                        msgCommand = EMessageCommand.Entered;
                    }
                    if (msg[1] == msgComputerLeft)
                    {
                        msgCommand = EMessageCommand.Left;
                    }
                }
                finally
                {
                }
            }
        }

        public string Message;
        public EMessageCommand msgCommand;
        public string ComputerName;
    }
 
    public class networkUser {
        public string computerName;
        public string regionName;
        public int coord_X;
        public int coord_Y;
    }

    public class NetworkMessenger : Component
    {
        // Messageria UDP 
        bool mActive = false;
        private int mPort = 17533;
        private string mBroadcastAddress = "255.255.255.255";

        UdpClient receivingClient;
        UdpClient sendingClient;

        ThreadStart start;
        Thread receivingThread;

        public networkUser[] lstNotes;

        public delegate void mensagemEventoHandler(object sender, messageArguments me);

        public event mensagemEventoHandler MessageReceived;
        public event mensagemEventoHandler ComputerEntered;
        public event mensagemEventoHandler ComputerLeft;
        public event mensagemEventoHandler MyCoordinates;
        public event mensagemEventoHandler MoveOutThere;
        
        ~NetworkMessenger()
        {
            try
            {
                if (mActive)
                    Active = false;
            }
            catch (Exception e)
            {
            }
        }

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                if (value)
                {
                    mActive = true;
                    try
                    {
                        InitializeSender();
                        InitializeReceiver();
                    }
                    catch (Exception e)
                    {
                        mActive = false;
                    }
                    SendMessageIEntered();
                }
                else
                {
                    SendMessageILeft();
                    try
                    {
                        FinalizeReceiver();
                        FinalizeSender();
                    }
                    finally
                    {
                    }
                    mActive = false;
                }
            }
        }

        public int PortNumber
        {
            get
            {
                return mPort;
            }
            set
            {
                Active = false;
            	mPort = value;
            }
        }

        public string BroadcastAddress
        {
            get
            {
                return mBroadcastAddress;
            }
            set
            {
                Active = false;
            	mBroadcastAddress = value;
            }
        }
        
        public virtual void OnMessageReceived(object sender, messageArguments e)
        {
            if (e.ComputerName != Environment.MachineName)
            {
                try
                {
                    if (MessageReceived != null)
                        MessageReceived(this, e);

                    if ((e.msgCommand == EMessageCommand.Entered) && (ComputerEntered != null))
                        ComputerEntered(this, e);

                    if ((e.msgCommand == EMessageCommand.Left) && (ComputerLeft != null))
                        ComputerLeft(this, e);

                    if ((e.msgCommand == EMessageCommand.MyCoordinates) && (MyCoordinates != null))
                        MyCoordinates(this, e);

                    if ((e.msgCommand == EMessageCommand.MoveOutThere) && (MoveOutThere != null))
                        MoveOutThere(this, e);

                }
                catch (Exception ex)
                {
                }

            }
        }


        private void InitializeReceiver()
        {
            start = new ThreadStart(Receiver);

            receivingClient = new UdpClient(mPort);

            receivingClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            receivingThread = new Thread(start) { IsBackground = true };
            receivingThread.Start();
        }

        private void FinalizeReceiver()
        {
            if (receivingThread!= null)
                receivingThread.Abort();
        }

        private void InitializeSender()
        {
            sendingClient = new UdpClient(mBroadcastAddress, mPort) { EnableBroadcast = true };
        }

        private void FinalizeSender()
        {
            if (sendingClient!=null)
                sendingClient.Close();
        }

        public void Receiver()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, mPort);

                while (true)
                {
                    byte[] data = receivingClient.Receive(ref endPoint);
                    string message = Encoding.ASCII.GetString(data);

                    /*
                    MensagemRecebidaDelegate locMensagem = new MensagemRecebidaDelegate(MensagemRecebida);

                    object[] par = { message };

                    Form thisForm = (Form)this.Container;

                    thisForm.Invoke(locMensagem, par);
                     */
                    MensagemRecebida(message);
                }
            }
            catch (Exception e)
            {
                mActive = false;
            }
        }

        public delegate void MensagemRecebidaDelegate(string mensagem);

        private void MensagemRecebida(string message)
        {
            messageArguments e = new messageArguments(message);
            /*

            MethodInfo mi = typeof(MensageiroRede).GetMethod("OnMessageReceived");

            object[] parMsg = new object[] { e };

            mi.Invoke(this, parMsg );
            */
            OnMessageReceived(this, e);
        }

        public void SendNetMessage(string message)
        {
            if (mActive && (message != ""))
            {
                string toSend = String.Format("{0}|{1}", Environment.MachineName, message);

                byte[] data = Encoding.ASCII.GetBytes(toSend);

                sendingClient.Send(data, data.Length);
            }
        }

        public void SendMessageIEntered()
        {
            SendNetMessage(messageArguments.msgComputerEntered);
        }

        public void SendMessageILeft()
        {
            SendNetMessage(messageArguments.msgComputerLeft);
        }

        public void enviarLoguei(string usuario)
        {
            SendNetMessage(String.Format("Logou|{0}", usuario));
        }

        public void enviarDesloguei(string usuario)
        {
            SendNetMessage(String.Format("Deslogou|{0}", usuario));
        }


    }
}

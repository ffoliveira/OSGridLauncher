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
using CookComputing.XmlRpc;
using System.Collections;

namespace OSGridLauncher
{
    [XmlRpcUrl("http://localhost:9000/")]
    public interface RemoteOpensim : IXmlRpcProxy
    {
        [XmlRpcMethod("admin_save_oar")]
        XmlRpcStruct admin_save_oar(XmlRpcStruct Parameters);

        [XmlRpcMethod("admin_load_oar")]
        XmlRpcStruct admin_load_oar(XmlRpcStruct Parameters);

        [XmlRpcMethod("admin_shutdown")]
        XmlRpcStruct admin_shutdown(XmlRpcStruct Parameters);
    }

    class OSRemoteAdmin 
    {

        public string server { get; set; }

        public string password { get; set; }

        public static bool admin_shutdown(string password)
        {
            XmlRpcStruct shutAccept = new XmlRpcStruct();
            XmlRpcStruct shutParms = new XmlRpcStruct();

            shutParms.Add("password", password);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            shutAccept = admin.admin_shutdown(shutParms);

            bool retShut = false;

            foreach (DictionaryEntry ReturnResults in shutAccept)
             {
                 if ((ReturnResults.Key.ToString() == "success") && ( (bool)ReturnResults.Value) )
                 {
                     retShut = true;
                     break;
                 }
            }
 
            return retShut;
        }

        public static bool admin_save_oar(string password, string nomeRegiao, string oarfile)
        {
            XmlRpcStruct saveAccept = new XmlRpcStruct();
            XmlRpcStruct saveParms = new XmlRpcStruct();

            saveParms.Add("password", password);
            saveParms.Add("region_name", nomeRegiao);
            saveParms.Add("filename", oarfile);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            try
            {
                saveAccept = admin.admin_save_oar(saveParms);
            }
            catch
            {
                return false;
            }

            bool retShut = true;

            /*
            foreach (DictionaryEntry ReturnResults in saveAccept)
            {
                if ((ReturnResults.Key.ToString() == "success") && ((bool)ReturnResults.Value))
                {
                    retShut = true;
                    break;
                }
            }
            */

            return retShut;
        }

        public static bool admin_restore_oar(string password, string nomeRegiao, string oarfile)
        {
            XmlRpcStruct saveAccept = new XmlRpcStruct();
            XmlRpcStruct saveParms = new XmlRpcStruct();

            saveParms.Add("password", password);
            saveParms.Add("region_name", nomeRegiao);
            saveParms.Add("filename", oarfile);

            RemoteOpensim admin = XmlRpcProxyGen.Create<RemoteOpensim>();

            try
            {
                saveAccept = admin.admin_load_oar(saveParms);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }

}

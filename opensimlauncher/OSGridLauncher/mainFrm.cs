// Author:
//   Adam Frisby <adam@deepthink.com.au>
//
// Copyright (C) 2009 OSGrid, Inc.                                  (r01-r19)
// Copyright (C) 2009-2010 DeepThink Pty Ltd - www.deepthink.com.au (r20+)
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
using System.IO;
using System.Windows.Forms;
using Nini.Config;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OSGridLauncher
{
    public partial class mainFrm : Form
    {
        private classes.NetworkMessenger oNetMsg;

        public mainFrm()
        {
            InitializeComponent();

        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            frameRegionConfig1.parentStatusStrip = statusStrip1;
            frameRegionConfig1.CarregarConfiguracoes();

            oNetMsg = new classes.NetworkMessenger() { Active = true };

            textLocalIP.Text = "N/A";
            textInternetIP.Text = "N/A";

            try
            {
                textLocalIP.Text = OpenSimConfigurator.GetLocalIP().ToString();
                textInternetIP.Text = OpenSimConfigurator.GetInternetIP().ToString();
            }
            finally
            {
            }
            frameRegionConfig1.LocalIP = textLocalIP.Text;
            frameRegionConfig1.RemoteIP = textInternetIP.Text;
            frameRegionConfig1.chkTryChangeRouter = chkTryChangeRouter.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osgrid.org/");
        }

        private void sponsorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.simhost.com/");
        }

        private void linkSeeTheMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osgrid.org/index.php/gridmap");
        }

        private void sponsor2Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://oliveira.eti.br/");
        }

        private void OSGridLaunch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osgrid.org/");
        }

        private void mainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            oNetMsg.Active = false;
        }

        private void chkTryChangeRouter_CheckedChanged(object sender, EventArgs e)
        {
            frameRegionConfig1.chkTryChangeRouter = chkTryChangeRouter.Checked;
        }

    }
}

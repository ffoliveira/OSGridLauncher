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
using CookComputing.XmlRpc;

namespace OSGridLauncher
{
    public partial class mainFrm : Form
    {
        private string iniFileRegiao;
        private string iniFileOpenSim;
        private string oarDir;

        private string senhaRegiao = "A17533g82Ol";

        public mainFrm()
        {
            InitializeComponent();

            oarDir = SOPath(Environment.CurrentDirectory + "\\oarfiles");

            if (!File.Exists(oarDir))
            {
                Directory.CreateDirectory(oarDir);
            }
            ReloadOARFileList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            edtNomeRegiao2.Text = edtNomeRegiao.Text;
            
            if (chkUpdateIPS.Checked)
            {
                AtualizaIPSIM();
            }

            int x =0, y =0;
            Int32.TryParse(textBoxX.Text, out x);
            Int32.TryParse(textBoxY.Text, out y);

            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            checkBoxAutoposition.Enabled = false;
            edtEstateName.Enabled = false;
            edtNomeRegiao.Enabled = false;
            edtAvatarName.Enabled = false;
            edtAvatarFamilyName.Enabled = false;
            chkUpdateIPS.Enabled = false;
            chkTryChangeRouter.Enabled = false;

            Guid novaSenha = Guid.NewGuid(); 

            senhaRegiao = novaSenha.ToString();

            OpenSimConfigurator osc = new OpenSimConfigurator();

            osc.ConfigAndLaunch(edtNomeRegiao.Text, edtAvatarName.Text, edtAvatarFamilyName.Text, progressBar1, toolStripStatusLabel1,
                                statusStrip1, checkBoxAutoposition.Checked, x, y, edtEstateName.Text, chkTryChangeRouter.Checked,
                                senhaRegiao, pgcAdminRegiao);

            //pgcAdminRegiao.SelectedTab = tbsAdministracao;
        }

        private void CarregarConfiguracoes()
        {
            if (Directory.Exists( SOPath(Environment.CurrentDirectory + "\\opensim")) )
            {
                textBoxX.ReadOnly = true;
                textBoxY.ReadOnly = true;

                btnChange.Visible = true;

                edtNomeRegiao.Text = "Already Configured";
                edtNomeRegiao.ReadOnly = true;

                edtAvatarName.Text = "Already Configured";
                edtAvatarName.ReadOnly = true;

                edtAvatarFamilyName.Text = "Already Configured";
                edtAvatarFamilyName.ReadOnly = true;

                edtEstateName.Text = "Already Configured";
                edtEstateName.ReadOnly = true;

                checkBoxAutoposition.Enabled = false;

                iniFileRegiao = SOPath(Environment.CurrentDirectory + "\\opensim\\bin\\Regions\\RegionConfig.ini");
                iniFileOpenSim = SOPath(Environment.CurrentDirectory + "\\opensim\\bin\\OpenSim.ini");

                IConfigSource oIniRegion = new IniConfigSource(iniFileRegiao);

                if (oIniRegion.Configs.Count > 0)
                {
                    edtNomeRegiao.Text = oIniRegion.Configs[0].Name;

                    string[] locs = oIniRegion.Configs[0].GetString("Location").Split(',');
                    textBoxX.Text = locs[0];
                    textBoxY.Text = locs[1];
                }

                IConfigSource oIniOS = new IniConfigSource(iniFileOpenSim);

                if (oIniOS.Configs["EstateDefaults"] != null)
                {
                    string estateOwner = oIniOS.Configs["EstateDefaults"].GetString("EstateOwner", "");
                    string[] ownerNames = estateOwner.Split(' ');

                    if (ownerNames.Length == 2)
                    {
                        edtAvatarName.Text = ownerNames[0];
                        edtAvatarFamilyName.Text = ownerNames[1];
                    }
                    edtEstateName.Text = oIniOS.Configs["EstateDefaults"].GetString("EstateName", "");
                }

                checkBoxAutoposition.Enabled = false;
            }
        }

        public static string SOPath(string caminho)
        {
            return caminho.Replace('\\', Path.DirectorySeparatorChar);
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            pgcAdminRegiao.SelectedTab = tbsConfiguracao;

            CarregarConfiguracoes();

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

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osgrid.org/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxX.ReadOnly)
                return;

            int d = -1;
            if (Int32.TryParse(textBoxX.Text, out d) && d.ToString() == textBoxX.Text)
            {
                if (Convert.ToInt32(textBoxX.Text) >= 65536 || Convert.ToInt32(textBoxX.Text) < 0)
                {
                    e.Cancel = true;
                    textBoxX.SelectAll();
                    errorProvider1.SetError(textBoxX, "Value must be between 0 and 65,535");
                    return;
                }
            }
            else
            {
                e.Cancel = true;
                textBoxX.SelectAll();
                errorProvider1.SetError(textBoxX, "Value must be numeric.");
                return;
            }
        }

        private void textBoxY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(textBoxY.ReadOnly)
                return;

            int d = -1;
            if (Int32.TryParse(textBoxY.Text, out d) && d.ToString() == textBoxY.Text)
            {
                if (Convert.ToInt32(textBoxY.Text) >= 65536 || Convert.ToInt32(textBoxY.Text) < 0)
                {
                    e.Cancel = true;
                    textBoxY.SelectAll();
                    errorProvider1.SetError(textBoxY, "Value must be between 0 and 65,535");
                    return;
                }
            }
            else
            {
                e.Cancel = true;
                textBoxY.SelectAll();
                errorProvider1.SetError(textBoxY, "Value must be numeric.");
                return;
            }
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (edtNomeRegiao.ReadOnly)
                return;

            if(edtNomeRegiao.Text.Length > 64)
            {
                e.Cancel = true;
                edtNomeRegiao.SelectAll();
                errorProvider1.SetError(edtNomeRegiao,"Must be less than 64 characters");
                return;
            }
            if(String.IsNullOrEmpty(edtNomeRegiao.Text))
            {
                e.Cancel = true;
                edtNomeRegiao.SelectAll();
                errorProvider1.SetError(edtNomeRegiao, "Must be at least one character long.");
                return;
            }
        }

        private void checkBoxAutoposition_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoposition.Checked)
            {
                textBoxX.ReadOnly = true;
                textBoxY.ReadOnly = true;
            }
            else
            {
                textBoxX.ReadOnly = false;
                textBoxY.ReadOnly = false;
            }
        }

        private void textBoxX_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxX, "");
        }

        private void textBoxY_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxY, "");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(edtNomeRegiao, "");
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            textBoxX.ReadOnly = false;
            textBoxY.ReadOnly = false;
            checkBoxAutoposition.Enabled = true;

            textBoxY.Focus();
            btnChange.Visible = false;
            btnGravaXY.Visible = true;
            btnCancelXY.Visible = true;
        }

        private void AtualizaIPSIM()
        {
            if ((iniFileRegiao != "") && (iniFileRegiao != null))
            {
                IConfigSource source = new IniConfigSource(iniFileRegiao);
                source.Configs[0].Set("InternalAddress", textLocalIP.Text);
                source.Configs[0].Set("ExternalHostName", textInternetIP.Text);
                source.Save();
            }
        }

        private void btnGravaXY_Click(object sender, EventArgs e)
        {
            IConfigSource source = new IniConfigSource(iniFileRegiao);

            source.Configs[0].Set("Location", textBoxX.Text + "," + textBoxY.Text);
            source.Save();

            btnCancelXY_Click(sender, e);
        }

        private void btnCancelXY_Click(object sender, EventArgs e)
        {
            btnGravaXY.Visible = false;
            btnCancelXY.Visible = false;
            checkBoxAutoposition.Enabled = false;

            CarregarConfiguracoes();
        }

        private void edtEstateName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (edtEstateName.ReadOnly)
                return;

            if (edtEstateName.Text.Length > 64)
            {
                e.Cancel = true;
                edtEstateName.SelectAll();
                errorProvider1.SetError(edtEstateName, "Must be less than 64 characters");
                return;
            }
            if (String.IsNullOrEmpty(edtEstateName.Text))
            {
                e.Cancel = true;
                edtEstateName.SelectAll();
                errorProvider1.SetError(edtEstateName, "Must be at least one character long.");
                return;
            }
        }

        private void pgcAdminRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            edtNomeRegiao2.Text = edtNomeRegiao.Text;

            if (pgcAdminRegiao.SelectedTab == tbsConfiguracao)
            {
                ReloadOARFileList();
            }
        }

        private void ReloadOARFileList()
        {
            lsbArquivosBackup.Items.Clear();
            string[] arqOARs = Directory.GetFiles(oarDir);

            for (int iOar = 0; iOar < arqOARs.Length; iOar++)
            {
                lsbArquivosBackup.Items.Add( Path.GetFileName(arqOARs[iOar]) );
            }

            btnRestoreOAR.Enabled = false;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            OSRemoteAdmin osr = new OSRemoteAdmin();

            if (osr.admin_shutdown(senhaRegiao))
            {
                MessageBox.Show("Shutdown accepted and in progress.");
            }
            else
            {
                MessageBox.Show("Shutdown wasn't accepted by the simulator");
            }
        }

        private void btnBackupOAR_Click(object sender, EventArgs e)
        {
            string nomeOAR = String.Format("{0:yyyy-MM-dd-HH-mm}.oar", DateTime.Now);

            OSRemoteAdmin osr = new OSRemoteAdmin();

            if (osr.admin_save_oar(senhaRegiao, edtNomeRegiao.Text, SOPath(oarDir+"\\"+nomeOAR)))
            {
                MessageBox.Show(String.Format("OAR Backup is running. File : {0}", nomeOAR));
                ReloadOARFileList();
            }
            else
            {
                MessageBox.Show("OAR Backup wasn't accepted by the simulator");
            }

        }

        private void btnRestoreOAR_Click(object sender, EventArgs e)
        {
            string nomeOAR = lsbArquivosBackup.Items[lsbArquivosBackup.SelectedIndex].ToString();

            if (MessageBox.Show(String.Format("Confirm restore the OAR file {0} ?\n\nCurrent content will be LOST !", nomeOAR), "Restore OAR File", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                OSRemoteAdmin osr = new OSRemoteAdmin();

                if (osr.admin_restore_oar(senhaRegiao, edtNomeRegiao.Text, SOPath(oarDir+"\\"+nomeOAR)))
                {
                    MessageBox.Show(String.Format("OAR Restore is running. File : {0}", nomeOAR));
                }
                else
                {
                    MessageBox.Show("OAR Restore wasn't accepted by the simulator");
                }
            }
        }

        private void lsbArquivosBackup_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRestoreOAR.Enabled = (lsbArquivosBackup.SelectedIndex >= 0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Nini.Config;

namespace OSGridLauncher.frames
{
    public partial class frameRegionConfig : UserControl
    {
        private string iniFileRegiao;
        private string iniFileOpenSim;
        private string oarDir;

        private Process oProcessoOS;

        private string senhaRegiao = "A17533g82Ol";

        public StatusStrip parentStatusStrip;
        public string LocalIP = "";
        public string RemoteIP = "";
        public bool chkUpdateIPS = true;
        public bool chkTryChangeRouter = false;

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public frameRegionConfig()
        {
            InitializeComponent();
            oarDir = classes.utilities.SOPath(Environment.CurrentDirectory + "\\oarfiles");

            if (!File.Exists(oarDir))
            {
                Directory.CreateDirectory(oarDir);
            }
            ReloadOARFileList();
        }

        public void CarregarConfiguracoes()
        {
            if (Directory.Exists(classes.utilities.SOPath(Environment.CurrentDirectory + "\\opensim")))
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

                iniFileRegiao = classes.utilities.SOPath(Environment.CurrentDirectory + "\\opensim\\bin\\Regions\\RegionConfig.ini");
                iniFileOpenSim = classes.utilities.SOPath(Environment.CurrentDirectory + "\\opensim\\bin\\OpenSim.ini");

                IConfigSource oIniRegion = new IniConfigSource(iniFileRegiao);

                if (oIniRegion.Configs.Count > 0)
                {
                    edtNomeRegiao.Text = oIniRegion.Configs[0].Name;

                    string[] locs = oIniRegion.Configs[0].GetString("Location").Split(',');
                    textBoxX.Text = locs[0];
                    textBoxY.Text = locs[1];
                    
                    checkBoxAutoposition.CheckState = CheckState.Indeterminate;
                }


                IConfigSource oIniOS = new IniConfigSource(iniFileOpenSim);

                if (oIniOS.Configs["Estates"] != null)
                {
                    string estateOwner = oIniOS.Configs["Estates"].GetString("DefaultEstateOwnerName", "");
                    string[] ownerNames = estateOwner.Split(' ');

                    if (ownerNames.Length == 2)
                    {
                        edtAvatarName.Text = ownerNames[0];
                        edtAvatarFamilyName.Text = ownerNames[1];
                    }
                    edtEstateName.Text = oIniOS.Configs["Estates"].GetString("DefaultEstateName", "");
                }

                checkBoxAutoposition.Enabled = false;


            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            edtNomeRegiao2.Text = edtNomeRegiao.Text;

            if (chkUpdateIPS)
            {
                AtualizaIPSIM();
            }

            int x = 0, y = 0;
            Int32.TryParse(textBoxX.Text, out x);
            Int32.TryParse(textBoxY.Text, out y);

            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            checkBoxAutoposition.Enabled = false;
            edtEstateName.Enabled = false;
            edtNomeRegiao.Enabled = false;
            edtAvatarName.Enabled = false;
            edtAvatarFamilyName.Enabled = false;

            Guid novaSenha = Guid.NewGuid();

            senhaRegiao = novaSenha.ToString();

            OpenSimConfigurator osc = new OpenSimConfigurator();

            ToolStripStatusLabel tspLb = (parentStatusStrip.Items.Count > 0 ? (ToolStripStatusLabel)parentStatusStrip.Items[0] : new ToolStripStatusLabel(""));


            osc.ConfigAndLaunch(edtNomeRegiao.Text, edtAvatarName.Text, edtAvatarFamilyName.Text, progressBarLauncher, tspLb,
                                parentStatusStrip, checkBoxAutoposition.Checked, x, y, edtEstateName.Text, chkTryChangeRouter,
                                senhaRegiao, pgcAdminRegiao, oProcessoOS);

            //pgcAdminRegiao.SelectedTab = tbsAdministracao;
        }

        private void edtEstateName_Validating(object sender, CancelEventArgs e)
        {
            if (edtEstateName.ReadOnly)
                return;

            if (edtEstateName.Text.Length > 64)
            {
                e.Cancel = true;
                edtEstateName.SelectAll();
                errorProviderFrame.SetError(edtEstateName, "Must be less than 64 characters");
                return;
            }
            if (String.IsNullOrEmpty(edtEstateName.Text))
            {
                e.Cancel = true;
                edtEstateName.SelectAll();
                errorProviderFrame.SetError(edtEstateName, "Must be at least one character long.");
                return;
            }
        }

        private void edtNomeRegiao_Validating(object sender, CancelEventArgs e)
        {
            if (edtNomeRegiao.ReadOnly)
                return;

            if (edtNomeRegiao.Text.Length > 64)
            {
                e.Cancel = true;
                edtNomeRegiao.SelectAll();
                errorProviderFrame.SetError(edtNomeRegiao, "Must be less than 64 characters");
                return;
            }
            if (String.IsNullOrEmpty(edtNomeRegiao.Text))
            {
                e.Cancel = true;
                edtNomeRegiao.SelectAll();
                errorProviderFrame.SetError(edtNomeRegiao, "Must be at least one character long.");
                return;
            }

        }

        private void edtNomeRegiao_Validated(object sender, EventArgs e)
        {
            errorProviderFrame.SetError(edtNomeRegiao, "");
        }

        private void edtEstateName_Validated(object sender, EventArgs e)
        {
            errorProviderFrame.SetError(edtEstateName, "");
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

        private void textBoxX_Validating(object sender, CancelEventArgs e)
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
                    errorProviderFrame.SetError(textBoxX, "Value must be between 0 and 65,535");
                    return;
                }
            }
            else
            {
                e.Cancel = true;
                textBoxX.SelectAll();
                errorProviderFrame.SetError(textBoxX, "Value must be numeric.");
                return;
            }
        }

        private void textBoxX_Validated(object sender, EventArgs e)
        {
            errorProviderFrame.SetError(textBoxX, "");
        }

        private void textBoxY_Validated(object sender, EventArgs e)
        {
            errorProviderFrame.SetError(textBoxY, "");
        }

        private void textBoxY_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxY.ReadOnly)
                return;

            int d = -1;
            if (Int32.TryParse(textBoxY.Text, out d) && d.ToString() == textBoxY.Text)
            {
                if (Convert.ToInt32(textBoxY.Text) >= 65536 || Convert.ToInt32(textBoxY.Text) < 0)
                {
                    e.Cancel = true;
                    textBoxY.SelectAll();
                    errorProviderFrame.SetError(textBoxY, "Value must be between 0 and 65,535");
                    return;
                }
            }
            else
            {
                e.Cancel = true;
                textBoxY.SelectAll();
                errorProviderFrame.SetError(textBoxY, "Value must be numeric.");
                return;
            }

        }

        private void btnGravaXY_Click(object sender, EventArgs e)
        {
            IConfigSource source = new IniConfigSource(iniFileRegiao);

            source.Configs[0].Set("Location", String.Format("{0},{1}", textBoxX.Text, textBoxY.Text));
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

        private void pgcAdminRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            edtNomeRegiao2.Text = edtNomeRegiao.Text;

            if (pgcAdminRegiao.SelectedTab == tbsConfiguracao)
            {
                ReloadOARFileList();
            }
        }

        private void btnHideShowConsole_Click(object sender, EventArgs e)
        {
            if (oProcessoOS != null)
            {
                // not working
                // ShowWindow(oProcessoOS.MainWindowHandle, SW_HIDE);
            }

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (OSRemoteAdmin.admin_shutdown(senhaRegiao))
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

            if (OSRemoteAdmin.admin_save_oar(senhaRegiao, edtNomeRegiao.Text, classes.utilities.SOPath(String.Format("{0}\\{1}", oarDir, nomeOAR))))
            {
                MessageBox.Show(String.Format("OAR Backup is running. File : {0}", nomeOAR));
                ReloadOARFileList();
            }
            else
            {
                MessageBox.Show("OAR Backup wasn't accepted by the simulator");
            }

        }

        private void lsbArquivosBackup_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRestoreOAR.Enabled = (lsbArquivosBackup.SelectedIndex >= 0);
        }

        private void btnRestoreOAR_Click(object sender, EventArgs e)
        {
            string nomeOAR = lsbArquivosBackup.Items[lsbArquivosBackup.SelectedIndex].ToString();

            if (MessageBox.Show(String.Format("Confirm restore the OAR file {0} ?\n\nCurrent content will be LOST !", nomeOAR), "Restore OAR File", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                if (OSRemoteAdmin.admin_restore_oar(senhaRegiao, edtNomeRegiao.Text, classes.utilities.SOPath(String.Format("{0}\\{1}", oarDir, nomeOAR))))
                {
                    MessageBox.Show(String.Format("OAR Restore is running. File : {0}", nomeOAR));
                }
                else
                {
                    MessageBox.Show("OAR Restore wasn't accepted by the simulator");
                }
            }
        }

        private void ReloadOARFileList()
        {
            lsbArquivosBackup.Items.Clear();
            string[] arqOARs = Directory.GetFiles(oarDir);

            for (int iOar = 0; iOar < arqOARs.Length; iOar++)
            {
                lsbArquivosBackup.Items.Add(Path.GetFileName(arqOARs[iOar]));
            }

            btnRestoreOAR.Enabled = false;
        }

        private void AtualizaIPSIM()
        {
            if ((iniFileRegiao != "") && (iniFileRegiao != null))
            {
                IConfigSource source = new IniConfigSource(iniFileRegiao);
                source.Configs[0].Set("InternalAddress", LocalIP);
                source.Configs[0].Set("ExternalHostName", RemoteIP);
                source.Save();
            }
        }

        private void frameRegionConfig_Load(object sender, EventArgs e)
        {
            pgcAdminRegiao.SelectedTab = tbsConfiguracao;
        }

    }
}

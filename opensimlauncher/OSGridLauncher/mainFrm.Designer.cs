namespace OSGridLauncher
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNomeRegiao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtAvatarName = new System.Windows.Forms.TextBox();
            this.edtAvatarFamilyName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.edtEstateName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkUpdateIPS = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textInternetIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.btnCancelXY = new System.Windows.Forms.Button();
            this.btnGravaXY = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.linkSeeTheMap = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.checkBoxAutoposition = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.OSGridLaunch = new System.Windows.Forms.PictureBox();
            this.sponsorButton = new System.Windows.Forms.PictureBox();
            this.sponsor2Button = new System.Windows.Forms.PictureBox();
            this.chkTryChangeRouter = new System.Windows.Forms.CheckBox();
            this.pgcAdminRegiao = new System.Windows.Forms.TabControl();
            this.tbsConfiguracao = new System.Windows.Forms.TabPage();
            this.pnlLancamento = new System.Windows.Forms.Panel();
            this.tbsAdministracao = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRestoreOAR = new System.Windows.Forms.Button();
            this.lsbArquivosBackup = new System.Windows.Forms.ListBox();
            this.btnBackupOAR = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.edtNomeRegiao2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHideShowConsole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSGridLaunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2Button)).BeginInit();
            this.pgcAdminRegiao.SuspendLayout();
            this.tbsConfiguracao.SuspendLayout();
            this.pnlLancamento.SuspendLayout();
            this.tbsAdministracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(447, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(456, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Launch";
            this.toolDicas.SetToolTip(this.btnStart, "Click here to start your SIM");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Region Name";
            // 
            // edtNomeRegiao
            // 
            this.edtNomeRegiao.Location = new System.Drawing.Point(222, 40);
            this.edtNomeRegiao.Name = "edtNomeRegiao";
            this.edtNomeRegiao.Size = new System.Drawing.Size(292, 20);
            this.edtNomeRegiao.TabIndex = 2;
            this.toolDicas.SetToolTip(this.edtNomeRegiao, "Inform Region name to be registered at OSGrid");
            this.edtNomeRegiao.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.edtNomeRegiao.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Region Owner Avatar Name";
            // 
            // edtAvatarName
            // 
            this.edtAvatarName.Location = new System.Drawing.Point(222, 134);
            this.edtAvatarName.Name = "edtAvatarName";
            this.edtAvatarName.Size = new System.Drawing.Size(117, 20);
            this.edtAvatarName.TabIndex = 9;
            this.toolDicas.SetToolTip(this.edtAvatarName, "Name of Avatar");
            // 
            // edtAvatarFamilyName
            // 
            this.edtAvatarFamilyName.Location = new System.Drawing.Point(361, 134);
            this.edtAvatarFamilyName.Name = "edtAvatarFamilyName";
            this.edtAvatarFamilyName.Size = new System.Drawing.Size(115, 20);
            this.edtAvatarFamilyName.TabIndex = 10;
            this.toolDicas.SetToolTip(this.edtAvatarFamilyName, "Avatar Surname ");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(548, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "Idle.";
            // 
            // edtEstateName
            // 
            this.edtEstateName.Location = new System.Drawing.Point(222, 11);
            this.edtEstateName.Name = "edtEstateName";
            this.edtEstateName.Size = new System.Drawing.Size(292, 20);
            this.edtEstateName.TabIndex = 1;
            this.toolDicas.SetToolTip(this.edtEstateName, "Inform Estate name to register your region in");
            this.edtEstateName.Validating += new System.ComponentModel.CancelEventHandler(this.edtEstateName_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Estate Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "QUIT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(8, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "To Close OpenSim window type:";
            // 
            // chkUpdateIPS
            // 
            this.chkUpdateIPS.AutoSize = true;
            this.chkUpdateIPS.Checked = true;
            this.chkUpdateIPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdateIPS.Location = new System.Drawing.Point(222, 190);
            this.chkUpdateIPS.Name = "chkUpdateIPS";
            this.chkUpdateIPS.Size = new System.Drawing.Size(201, 17);
            this.chkUpdateIPS.TabIndex = 12;
            this.chkUpdateIPS.Text = "Auto-update my config with these IPs";
            this.chkUpdateIPS.UseVisualStyleBackColor = true;
            this.chkUpdateIPS.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Internet IP";
            // 
            // textInternetIP
            // 
            this.textInternetIP.Location = new System.Drawing.Point(397, 213);
            this.textInternetIP.Name = "textInternetIP";
            this.textInternetIP.ReadOnly = true;
            this.textInternetIP.Size = new System.Drawing.Size(117, 20);
            this.textInternetIP.TabIndex = 14;
            this.textInternetIP.TabStop = false;
            this.toolDicas.SetToolTip(this.textInternetIP, "Name of Avatar");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Local IP";
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(222, 213);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.ReadOnly = true;
            this.textLocalIP.Size = new System.Drawing.Size(107, 20);
            this.textLocalIP.TabIndex = 13;
            this.textLocalIP.TabStop = false;
            this.toolDicas.SetToolTip(this.textLocalIP, "Name of Avatar");
            // 
            // btnCancelXY
            // 
            this.btnCancelXY.Location = new System.Drawing.Point(466, 90);
            this.btnCancelXY.Name = "btnCancelXY";
            this.btnCancelXY.Size = new System.Drawing.Size(48, 23);
            this.btnCancelXY.TabIndex = 7;
            this.btnCancelXY.Text = "Cancel";
            this.btnCancelXY.UseVisualStyleBackColor = true;
            this.btnCancelXY.Visible = false;
            this.btnCancelXY.Click += new System.EventHandler(this.btnCancelXY_Click);
            // 
            // btnGravaXY
            // 
            this.btnGravaXY.Location = new System.Drawing.Point(419, 90);
            this.btnGravaXY.Name = "btnGravaXY";
            this.btnGravaXY.Size = new System.Drawing.Size(41, 23);
            this.btnGravaXY.TabIndex = 6;
            this.btnGravaXY.Text = "Save";
            this.btnGravaXY.UseVisualStyleBackColor = true;
            this.btnGravaXY.Visible = false;
            this.btnGravaXY.Click += new System.EventHandler(this.btnGravaXY_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(429, 90);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(57, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // linkSeeTheMap
            // 
            this.linkSeeTheMap.AutoSize = true;
            this.linkSeeTheMap.Location = new System.Drawing.Point(8, 108);
            this.linkSeeTheMap.Name = "linkSeeTheMap";
            this.linkSeeTheMap.Size = new System.Drawing.Size(108, 13);
            this.linkSeeTheMap.TabIndex = 15;
            this.linkSeeTheMap.TabStop = true;
            this.linkSeeTheMap.Text = "Find it at OSGrid Map";
            this.linkSeeTheMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSeeTheMap_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your OSgrid.org Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = ",";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(351, 90);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(62, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxY_Validating);
            this.textBoxY.Validated += new System.EventHandler(this.textBoxY_Validated);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(8, 164);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(126, 13);
            this.linkRegister.TabIndex = 9;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register a new account?";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(276, 91);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(53, 20);
            this.textBoxX.TabIndex = 4;
            this.textBoxX.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxX_Validating);
            this.textBoxX.Validated += new System.EventHandler(this.textBoxX_Validated);
            // 
            // checkBoxAutoposition
            // 
            this.checkBoxAutoposition.AutoSize = true;
            this.checkBoxAutoposition.Checked = true;
            this.checkBoxAutoposition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoposition.Location = new System.Drawing.Point(222, 93);
            this.checkBoxAutoposition.Name = "checkBoxAutoposition";
            this.checkBoxAutoposition.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAutoposition.TabIndex = 3;
            this.checkBoxAutoposition.Text = "Auto";
            this.checkBoxAutoposition.UseVisualStyleBackColor = true;
            this.checkBoxAutoposition.CheckedChanged += new System.EventHandler(this.checkBoxAutoposition_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Must be availible coordinates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "May be up to 64 alphanumeric characters";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(267, 20);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(25, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "r0.7";
            // 
            // OSGridLaunch
            // 
            this.OSGridLaunch.BackColor = System.Drawing.Color.Transparent;
            this.OSGridLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OSGridLaunch.InitialImage = null;
            this.OSGridLaunch.Location = new System.Drawing.Point(12, 1);
            this.OSGridLaunch.Name = "OSGridLaunch";
            this.OSGridLaunch.Size = new System.Drawing.Size(102, 43);
            this.OSGridLaunch.TabIndex = 13;
            this.OSGridLaunch.TabStop = false;
            this.toolDicas.SetToolTip(this.OSGridLaunch, "Click to visit SimHost website");
            this.OSGridLaunch.Click += new System.EventHandler(this.OSGridLaunch_Click);
            // 
            // sponsorButton
            // 
            this.sponsorButton.BackColor = System.Drawing.Color.Transparent;
            this.sponsorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sponsorButton.InitialImage = null;
            this.sponsorButton.Location = new System.Drawing.Point(402, 1);
            this.sponsorButton.Name = "sponsorButton";
            this.sponsorButton.Size = new System.Drawing.Size(146, 22);
            this.sponsorButton.TabIndex = 11;
            this.sponsorButton.TabStop = false;
            this.toolDicas.SetToolTip(this.sponsorButton, "Click to visit SimHost website");
            this.sponsorButton.Click += new System.EventHandler(this.sponsorButton_Click);
            // 
            // sponsor2Button
            // 
            this.sponsor2Button.BackColor = System.Drawing.Color.Transparent;
            this.sponsor2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sponsor2Button.InitialImage = null;
            this.sponsor2Button.Location = new System.Drawing.Point(331, 1);
            this.sponsor2Button.Name = "sponsor2Button";
            this.sponsor2Button.Size = new System.Drawing.Size(217, 41);
            this.sponsor2Button.TabIndex = 12;
            this.sponsor2Button.TabStop = false;
            this.toolDicas.SetToolTip(this.sponsor2Button, "Click to visit Oliveira Lands website");
            this.sponsor2Button.Click += new System.EventHandler(this.sponsor2Button_Click);
            // 
            // chkTryChangeRouter
            // 
            this.chkTryChangeRouter.AutoSize = true;
            this.chkTryChangeRouter.Location = new System.Drawing.Point(222, 167);
            this.chkTryChangeRouter.Name = "chkTryChangeRouter";
            this.chkTryChangeRouter.Size = new System.Drawing.Size(297, 17);
            this.chkTryChangeRouter.TabIndex = 11;
            this.chkTryChangeRouter.Text = "Try to configure my Router using uPNP (must be enabled)";
            this.chkTryChangeRouter.UseVisualStyleBackColor = true;
            // 
            // pgcAdminRegiao
            // 
            this.pgcAdminRegiao.Controls.Add(this.tbsConfiguracao);
            this.pgcAdminRegiao.Controls.Add(this.tbsAdministracao);
            this.pgcAdminRegiao.Location = new System.Drawing.Point(0, 50);
            this.pgcAdminRegiao.Name = "pgcAdminRegiao";
            this.pgcAdminRegiao.SelectedIndex = 0;
            this.pgcAdminRegiao.Size = new System.Drawing.Size(548, 313);
            this.pgcAdminRegiao.TabIndex = 14;
            this.pgcAdminRegiao.SelectedIndexChanged += new System.EventHandler(this.pgcAdminRegiao_SelectedIndexChanged);
            // 
            // tbsConfiguracao
            // 
            this.tbsConfiguracao.Controls.Add(this.chkTryChangeRouter);
            this.tbsConfiguracao.Controls.Add(this.pnlLancamento);
            this.tbsConfiguracao.Controls.Add(this.edtEstateName);
            this.tbsConfiguracao.Controls.Add(this.label12);
            this.tbsConfiguracao.Controls.Add(this.label11);
            this.tbsConfiguracao.Controls.Add(this.label1);
            this.tbsConfiguracao.Controls.Add(this.label10);
            this.tbsConfiguracao.Controls.Add(this.label2);
            this.tbsConfiguracao.Controls.Add(this.chkUpdateIPS);
            this.tbsConfiguracao.Controls.Add(this.edtNomeRegiao);
            this.tbsConfiguracao.Controls.Add(this.label9);
            this.tbsConfiguracao.Controls.Add(this.edtAvatarName);
            this.tbsConfiguracao.Controls.Add(this.textInternetIP);
            this.tbsConfiguracao.Controls.Add(this.edtAvatarFamilyName);
            this.tbsConfiguracao.Controls.Add(this.label8);
            this.tbsConfiguracao.Controls.Add(this.label3);
            this.tbsConfiguracao.Controls.Add(this.textLocalIP);
            this.tbsConfiguracao.Controls.Add(this.label6);
            this.tbsConfiguracao.Controls.Add(this.btnCancelXY);
            this.tbsConfiguracao.Controls.Add(this.label5);
            this.tbsConfiguracao.Controls.Add(this.btnGravaXY);
            this.tbsConfiguracao.Controls.Add(this.checkBoxAutoposition);
            this.tbsConfiguracao.Controls.Add(this.btnChange);
            this.tbsConfiguracao.Controls.Add(this.textBoxX);
            this.tbsConfiguracao.Controls.Add(this.linkSeeTheMap);
            this.tbsConfiguracao.Controls.Add(this.linkRegister);
            this.tbsConfiguracao.Controls.Add(this.label4);
            this.tbsConfiguracao.Controls.Add(this.textBoxY);
            this.tbsConfiguracao.Controls.Add(this.label7);
            this.tbsConfiguracao.Location = new System.Drawing.Point(4, 22);
            this.tbsConfiguracao.Name = "tbsConfiguracao";
            this.tbsConfiguracao.Padding = new System.Windows.Forms.Padding(3);
            this.tbsConfiguracao.Size = new System.Drawing.Size(540, 287);
            this.tbsConfiguracao.TabIndex = 0;
            this.tbsConfiguracao.Text = "Configuration Information";
            this.tbsConfiguracao.UseVisualStyleBackColor = true;
            // 
            // pnlLancamento
            // 
            this.pnlLancamento.Controls.Add(this.progressBar1);
            this.pnlLancamento.Controls.Add(this.btnStart);
            this.pnlLancamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLancamento.Location = new System.Drawing.Point(3, 253);
            this.pnlLancamento.Name = "pnlLancamento";
            this.pnlLancamento.Size = new System.Drawing.Size(534, 31);
            this.pnlLancamento.TabIndex = 10;
            // 
            // tbsAdministracao
            // 
            this.tbsAdministracao.Controls.Add(this.btnHideShowConsole);
            this.tbsAdministracao.Controls.Add(this.label14);
            this.tbsAdministracao.Controls.Add(this.btnRestoreOAR);
            this.tbsAdministracao.Controls.Add(this.lsbArquivosBackup);
            this.tbsAdministracao.Controls.Add(this.btnBackupOAR);
            this.tbsAdministracao.Controls.Add(this.btnShutdown);
            this.tbsAdministracao.Controls.Add(this.edtNomeRegiao2);
            this.tbsAdministracao.Controls.Add(this.label13);
            this.tbsAdministracao.Location = new System.Drawing.Point(4, 22);
            this.tbsAdministracao.Name = "tbsAdministracao";
            this.tbsAdministracao.Padding = new System.Windows.Forms.Padding(3);
            this.tbsAdministracao.Size = new System.Drawing.Size(540, 287);
            this.tbsAdministracao.TabIndex = 1;
            this.tbsAdministracao.Text = "Region Administration";
            this.tbsAdministracao.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(8, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Select the OAR File to Restore";
            // 
            // btnRestoreOAR
            // 
            this.btnRestoreOAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreOAR.Enabled = false;
            this.btnRestoreOAR.Location = new System.Drawing.Point(334, 249);
            this.btnRestoreOAR.Name = "btnRestoreOAR";
            this.btnRestoreOAR.Size = new System.Drawing.Size(197, 23);
            this.btnRestoreOAR.TabIndex = 9;
            this.btnRestoreOAR.Text = "Restore to OAR File";
            this.btnRestoreOAR.UseVisualStyleBackColor = true;
            this.btnRestoreOAR.Click += new System.EventHandler(this.btnRestoreOAR_Click);
            // 
            // lsbArquivosBackup
            // 
            this.lsbArquivosBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbArquivosBackup.FormattingEnabled = true;
            this.lsbArquivosBackup.Location = new System.Drawing.Point(8, 122);
            this.lsbArquivosBackup.Name = "lsbArquivosBackup";
            this.lsbArquivosBackup.Size = new System.Drawing.Size(523, 121);
            this.lsbArquivosBackup.TabIndex = 8;
            this.lsbArquivosBackup.SelectedIndexChanged += new System.EventHandler(this.lsbArquivosBackup_SelectedIndexChanged);
            // 
            // btnBackupOAR
            // 
            this.btnBackupOAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupOAR.Location = new System.Drawing.Point(334, 93);
            this.btnBackupOAR.Name = "btnBackupOAR";
            this.btnBackupOAR.Size = new System.Drawing.Size(197, 23);
            this.btnBackupOAR.TabIndex = 7;
            this.btnBackupOAR.Text = "Backup to OAR File";
            this.btnBackupOAR.UseVisualStyleBackColor = true;
            this.btnBackupOAR.Click += new System.EventHandler(this.btnBackupOAR_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(334, 32);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(197, 23);
            this.btnShutdown.TabIndex = 6;
            this.btnShutdown.Text = "Shutdown the Region";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // edtNomeRegiao2
            // 
            this.edtNomeRegiao2.Enabled = false;
            this.edtNomeRegiao2.Location = new System.Drawing.Point(86, 6);
            this.edtNomeRegiao2.Name = "edtNomeRegiao2";
            this.edtNomeRegiao2.Size = new System.Drawing.Size(445, 20);
            this.edtNomeRegiao2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Region Name";
            // 
            // btnHideShowConsole
            // 
            this.btnHideShowConsole.Location = new System.Drawing.Point(11, 32);
            this.btnHideShowConsole.Name = "btnHideShowConsole";
            this.btnHideShowConsole.Size = new System.Drawing.Size(197, 23);
            this.btnHideShowConsole.TabIndex = 26;
            this.btnHideShowConsole.Text = "Hide Console Window";
            this.btnHideShowConsole.UseVisualStyleBackColor = true;
            this.btnHideShowConsole.Visible = false;
            this.btnHideShowConsole.Click += new System.EventHandler(this.btnHideShowConsole_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OSGridLauncher.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.pgcAdminRegiao);
            this.Controls.Add(this.OSGridLaunch);
            this.Controls.Add(this.sponsorButton);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sponsor2Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "OSGrid Region Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrm_FormClosed);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSGridLaunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2Button)).EndInit();
            this.pgcAdminRegiao.ResumeLayout(false);
            this.tbsConfiguracao.ResumeLayout(false);
            this.tbsConfiguracao.PerformLayout();
            this.pnlLancamento.ResumeLayout(false);
            this.tbsAdministracao.ResumeLayout(false);
            this.tbsAdministracao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNomeRegiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtAvatarName;
        private System.Windows.Forms.TextBox edtAvatarFamilyName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAutoposition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox sponsorButton;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkSeeTheMap;
        private System.Windows.Forms.PictureBox sponsor2Button;
        private System.Windows.Forms.ToolTip toolDicas;
        private System.Windows.Forms.PictureBox OSGridLaunch;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancelXY;
        private System.Windows.Forms.Button btnGravaXY;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textInternetIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkUpdateIPS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtEstateName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkTryChangeRouter;
        private System.Windows.Forms.TabControl pgcAdminRegiao;
        private System.Windows.Forms.TabPage tbsConfiguracao;
        private System.Windows.Forms.TabPage tbsAdministracao;
        private System.Windows.Forms.TextBox edtNomeRegiao2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlLancamento;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnBackupOAR;
        private System.Windows.Forms.ListBox lsbArquivosBackup;
        private System.Windows.Forms.Button btnRestoreOAR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHideShowConsole;
    }
}


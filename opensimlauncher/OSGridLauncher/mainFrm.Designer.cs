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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.textInternetIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.linkSeeTheMap = new System.Windows.Forms.LinkLabel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.OSGridLaunch = new System.Windows.Forms.PictureBox();
            this.sponsorButton = new System.Windows.Forms.PictureBox();
            this.sponsor2Button = new System.Windows.Forms.PictureBox();
            this.pgcAllRegions = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTryChangeRouter = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.frameRegionConfig1 = new OSGridLauncher.frames.frameRegionConfig();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSGridLaunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2Button)).BeginInit();
            this.pgcAllRegions.SuspendLayout();
            this.tabDefault.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "Idle.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Internet IP";
            // 
            // textInternetIP
            // 
            this.textInternetIP.Location = new System.Drawing.Point(427, 19);
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
            this.label8.Location = new System.Drawing.Point(307, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Local IP";
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(310, 19);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.ReadOnly = true;
            this.textLocalIP.Size = new System.Drawing.Size(107, 20);
            this.textLocalIP.TabIndex = 13;
            this.textLocalIP.TabStop = false;
            this.toolDicas.SetToolTip(this.textLocalIP, "Name of Avatar");
            // 
            // linkSeeTheMap
            // 
            this.linkSeeTheMap.AutoSize = true;
            this.linkSeeTheMap.Location = new System.Drawing.Point(12, 45);
            this.linkSeeTheMap.Name = "linkSeeTheMap";
            this.linkSeeTheMap.Size = new System.Drawing.Size(184, 13);
            this.linkSeeTheMap.TabIndex = 15;
            this.linkSeeTheMap.TabStop = true;
            this.linkSeeTheMap.Text = "Find empty coordinate at OSGrid Map";
            this.linkSeeTheMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSeeTheMap_LinkClicked);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(11, 22);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(126, 13);
            this.linkRegister.TabIndex = 9;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register a new account?";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.lblVersion.Text = "r0.8";
            // 
            // OSGridLaunch
            // 
            this.OSGridLaunch.BackColor = System.Drawing.Color.Transparent;
            this.OSGridLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OSGridLaunch.InitialImage = null;
            this.OSGridLaunch.Location = new System.Drawing.Point(12, 1);
            this.OSGridLaunch.Name = "OSGridLaunch";
            this.OSGridLaunch.Size = new System.Drawing.Size(102, 41);
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
            this.sponsorButton.Visible = false;
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
            // pgcAllRegions
            // 
            this.pgcAllRegions.Controls.Add(this.tabDefault);
            this.pgcAllRegions.Location = new System.Drawing.Point(0, 48);
            this.pgcAllRegions.Name = "pgcAllRegions";
            this.pgcAllRegions.SelectedIndex = 0;
            this.pgcAllRegions.Size = new System.Drawing.Size(548, 321);
            this.pgcAllRegions.TabIndex = 15;
            // 
            // tabDefault
            // 
            this.tabDefault.Controls.Add(this.frameRegionConfig1);
            this.tabDefault.Location = new System.Drawing.Point(4, 22);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefault.Size = new System.Drawing.Size(540, 295);
            this.tabDefault.TabIndex = 0;
            this.tabDefault.Text = "Default Region";
            this.tabDefault.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkTryChangeRouter);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.linkRegister);
            this.panel1.Controls.Add(this.linkSeeTheMap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textLocalIP);
            this.panel1.Controls.Add(this.textInternetIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 70);
            this.panel1.TabIndex = 16;
            // 
            // chkTryChangeRouter
            // 
            this.chkTryChangeRouter.AutoSize = true;
            this.chkTryChangeRouter.Location = new System.Drawing.Point(244, 45);
            this.chkTryChangeRouter.Name = "chkTryChangeRouter";
            this.chkTryChangeRouter.Size = new System.Drawing.Size(297, 17);
            this.chkTryChangeRouter.TabIndex = 28;
            this.chkTryChangeRouter.Text = "Try to configure my Router using uPNP (must be enabled)";
            this.chkTryChangeRouter.UseVisualStyleBackColor = true;
            this.chkTryChangeRouter.CheckedChanged += new System.EventHandler(this.chkTryChangeRouter_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "OSGrid Info";
            // 
            // frameRegionConfig1
            // 
            this.frameRegionConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameRegionConfig1.Location = new System.Drawing.Point(3, 3);
            this.frameRegionConfig1.Name = "frameRegionConfig1";
            this.frameRegionConfig1.Size = new System.Drawing.Size(534, 289);
            this.frameRegionConfig1.TabIndex = 0;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OSGridLauncher.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(547, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgcAllRegions);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OSGridLaunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsor2Button)).EndInit();
            this.pgcAllRegions.ResumeLayout(false);
            this.tabDefault.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox sponsorButton;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkSeeTheMap;
        private System.Windows.Forms.PictureBox sponsor2Button;
        private System.Windows.Forms.ToolTip toolDicas;
        private System.Windows.Forms.PictureBox OSGridLaunch;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textInternetIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl pgcAllRegions;
        private System.Windows.Forms.TabPage tabDefault;
        private frames.frameRegionConfig frameRegionConfig1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox chkTryChangeRouter;
    }
}


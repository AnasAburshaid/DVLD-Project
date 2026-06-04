namespace DVLD

{

    partial class frmMainScreen

    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer generated code



        private void InitializeComponent()

        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ApplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.internationalDrivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationMenu,
            this.PeopleMenu,
            this.DriversMenu,
            this.UsersMenu,
            this.AccountSettingsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1118, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ApplicationMenu
            // 
            this.ApplicationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.sep1,
            this.manageApplicationToolStripMenuItem,
            this.sep2,
            this.detainLicencesToolStripMenuItem,
            this.sep3,
            this.manageToolStripMenuItem,
            this.sep4,
            this.manageTestTypesToolStripMenuItem});
            this.ApplicationMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.ApplicationMenu.Image = global::DVLD.Properties.Resources.Application;
            this.ApplicationMenu.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ApplicationMenu.Name = "ApplicationMenu";
            this.ApplicationMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ApplicationMenu.Size = new System.Drawing.Size(144, 27);
            this.ApplicationMenu.Text = "Application";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewToolStripMenuItem,
            this.replacementToolStripMenuItem,
            this.toolStripMenuItem4,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.retakeTestToolStripMenuItem});
            this.drivingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingToolStripMenuItem.Image = global::DVLD.Properties.Resources.drivingLicenseService;
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.drivingToolStripMenuItem.Text = "  Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.DrivingLIcenseInfo;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(395, 28);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.drivingLicenseService;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.international;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Image = global::DVLD.Properties.Resources.RenewDrivingLicense;
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(395, 28);
            this.renewToolStripMenuItem.Text = "Renew Driving License";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.renewToolStripMenuItem_Click);
            // 
            // replacementToolStripMenuItem
            // 
            this.replacementToolStripMenuItem.Image = global::DVLD.Properties.Resources.Replacment;
            this.replacementToolStripMenuItem.Name = "replacementToolStripMenuItem";
            this.replacementToolStripMenuItem.Size = new System.Drawing.Size(395, 28);
            this.replacementToolStripMenuItem.Text = "Replacement for lost or damage license";
            this.replacementToolStripMenuItem.Click += new System.EventHandler(this.replacementToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(392, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.ReleaseDetainedLicense;
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(395, 28);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(392, 6);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Retake_test;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(395, 28);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(302, 6);
            // 
            // manageApplicationToolStripMenuItem
            // 
            this.manageApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.internationalDrivingToolStripMenuItem});
            this.manageApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.ManageApplications;
            this.manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            this.manageApplicationToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.manageApplicationToolStripMenuItem.Text = "  Manage Application";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.drivingLicenseService;
            this.localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            this.localDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(343, 28);
            this.localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Application";
            this.localDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(340, 6);
            // 
            // internationalDrivingToolStripMenuItem
            // 
            this.internationalDrivingToolStripMenuItem.Image = global::DVLD.Properties.Resources.international;
            this.internationalDrivingToolStripMenuItem.Name = "internationalDrivingToolStripMenuItem";
            this.internationalDrivingToolStripMenuItem.Size = new System.Drawing.Size(343, 28);
            this.internationalDrivingToolStripMenuItem.Text = "International License Application";
            this.internationalDrivingToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingToolStripMenuItem_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(302, 6);
            // 
            // detainLicencesToolStripMenuItem
            // 
            this.detainLicencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetainedLicneseToolStripMenuItem});
            this.detainLicencesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainLicencesToolStripMenuItem.Image = global::DVLD.Properties.Resources.ManageLocked;
            this.detainLicencesToolStripMenuItem.Name = "detainLicencesToolStripMenuItem";
            this.detainLicencesToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.detainLicencesToolStripMenuItem.Text = "  Detained Licenses Services";
            // 
            // manageDetainedToolStripMenuItem
            // 
            this.manageDetainedToolStripMenuItem.Image = global::DVLD.Properties.Resources.ManageDetainedLicense;
            this.manageDetainedToolStripMenuItem.Name = "manageDetainedToolStripMenuItem";
            this.manageDetainedToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.manageDetainedToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.detainLicense;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(294, 6);
            // 
            // releaseDetainedLicneseToolStripMenuItem
            // 
            this.releaseDetainedLicneseToolStripMenuItem.Image = global::DVLD.Properties.Resources.ReleaseDetainedLicense;
            this.releaseDetainedLicneseToolStripMenuItem.Name = "releaseDetainedLicneseToolStripMenuItem";
            this.releaseDetainedLicneseToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.releaseDetainedLicneseToolStripMenuItem.Text = "Release Detained Licnese";
            this.releaseDetainedLicneseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicneseToolStripMenuItem_Click);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(302, 6);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageToolStripMenuItem.Image = global::DVLD.Properties.Resources.ManageApplicationTypes;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.manageToolStripMenuItem.Text = "  Manage Application Types";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(302, 6);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.ManageTestTypes;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(305, 28);
            this.manageTestTypesToolStripMenuItem.Text = "  Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // PeopleMenu
            // 
            this.PeopleMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.PeopleMenu.Image = global::DVLD.Properties.Resources.People;
            this.PeopleMenu.Name = "PeopleMenu";
            this.PeopleMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.PeopleMenu.Size = new System.Drawing.Size(109, 27);
            this.PeopleMenu.Text = "People";
            this.PeopleMenu.Click += new System.EventHandler(this.PeopleMenu_Click);
            // 
            // DriversMenu
            // 
            this.DriversMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.DriversMenu.Image = global::DVLD.Properties.Resources.Drivers;
            this.DriversMenu.Name = "DriversMenu";
            this.DriversMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.DriversMenu.Size = new System.Drawing.Size(111, 27);
            this.DriversMenu.Text = "Drivers";
            this.DriversMenu.Click += new System.EventHandler(this.DriversMenu_Click);
            // 
            // UsersMenu
            // 
            this.UsersMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.UsersMenu.Image = global::DVLD.Properties.Resources.Users2;
            this.UsersMenu.Name = "UsersMenu";
            this.UsersMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.UsersMenu.Size = new System.Drawing.Size(99, 27);
            this.UsersMenu.Text = "Users";
            this.UsersMenu.Click += new System.EventHandler(this.UsersMenu_Click);
            // 
            // AccountSettingsMenu
            // 
            this.AccountSettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sep6,
            this.toolStripMenuItem2});
            this.AccountSettingsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.AccountSettingsMenu.Image = global::DVLD.Properties.Resources.ProfileSettings;
            this.AccountSettingsMenu.Name = "AccountSettingsMenu";
            this.AccountSettingsMenu.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.AccountSettingsMenu.Size = new System.Drawing.Size(187, 27);
            this.AccountSettingsMenu.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.userInformation;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.currentUserInfoToolStripMenuItem.Text = "  Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password2;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.changePasswordToolStripMenuItem.Text = "  Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sep6
            // 
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.toolStripMenuItem2.Image = global::DVLD.Properties.Resources.logout;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 30);
            this.toolStripMenuItem2.Text = "  Sign Out";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "DVLD SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.labelSubtitle.Location = new System.Drawing.Point(3, 130);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(554, 36);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "Driving License Management  —  Welcome";
            this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1118, 56);
            this.panelTop.TabIndex = 2;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.Controls.Add(this.label1);
            this.panelCenter.Controls.Add(this.labelSubtitle);
            this.panelCenter.Location = new System.Drawing.Point(279, 280);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(560, 200);
            this.panelCenter.TabIndex = 1;
            // 
            // frmMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1118, 760);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD — Driving License Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Panel panelTop;

        private System.Windows.Forms.Panel panelCenter;

        private System.Windows.Forms.ToolStripMenuItem ApplicationMenu;

        private System.Windows.Forms.ToolStripMenuItem PeopleMenu;

        private System.Windows.Forms.ToolStripMenuItem DriversMenu;

        private System.Windows.Forms.ToolStripMenuItem UsersMenu;

        private System.Windows.Forms.ToolStripMenuItem AccountSettingsMenu;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelSubtitle;

        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem manageApplicationToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem detainLicencesToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator sep1;

        private System.Windows.Forms.ToolStripSeparator sep2;

        private System.Windows.Forms.ToolStripSeparator sep3;

        private System.Windows.Forms.ToolStripSeparator sep4;

        private System.Windows.Forms.ToolStripSeparator sep6;

        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem replacementToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem internationalDrivingToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem manageDetainedToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicneseToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

    }

}
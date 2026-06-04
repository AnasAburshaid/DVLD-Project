using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    partial class frmShowApplicationDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.pnlCardLocalApp = new System.Windows.Forms.Panel();
            this.pnlCardLocalAppHeader = new System.Windows.Forms.Panel();
            this.picCardLocalIcon = new System.Windows.Forms.PictureBox();
            this.lblCardLocalTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblLocalAppid = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblpassesTests = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.pnlCardAppInfo = new System.Windows.Forms.Panel();
            this.pnlCardAppHeader = new System.Windows.Forms.Panel();
            this.picCardAppIcon = new System.Windows.Forms.PictureBox();
            this.lblCardAppTitle = new System.Windows.Forms.Label();
            this.lblSecName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAppStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.LinkPersonInfo = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlCardLocalApp.SuspendLayout();
            this.pnlCardLocalAppHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardLocalIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.pnlCardAppInfo.SuspendLayout();
            this.pnlCardAppHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(892, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::DVLD.Properties.Resources.Application;
            this.picIcon.Location = new System.Drawing.Point(18, 14);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(82, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(238, 35);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Application Details";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(84, 52);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(365, 20);
            this.lblFormSubtitle.TabIndex = 2;
            this.lblFormSubtitle.Text = "Full details for the selected driving license application";
            // 
            // pnlCardLocalApp
            // 
            this.pnlCardLocalApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCardLocalApp.BackColor = System.Drawing.Color.White;
            this.pnlCardLocalApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardLocalApp.Controls.Add(this.pnlCardLocalAppHeader);
            this.pnlCardLocalApp.Controls.Add(this.label16);
            this.pnlCardLocalApp.Controls.Add(this.pictureBox11);
            this.pnlCardLocalApp.Controls.Add(this.lblLocalAppid);
            this.pnlCardLocalApp.Controls.Add(this.label17);
            this.pnlCardLocalApp.Controls.Add(this.pictureBox12);
            this.pnlCardLocalApp.Controls.Add(this.lblpassesTests);
            this.pnlCardLocalApp.Controls.Add(this.label6);
            this.pnlCardLocalApp.Controls.Add(this.label14);
            this.pnlCardLocalApp.Controls.Add(this.label18);
            this.pnlCardLocalApp.Controls.Add(this.pictureBox13);
            this.pnlCardLocalApp.Controls.Add(this.lblLicenseClass);
            this.pnlCardLocalApp.Location = new System.Drawing.Point(16, 96);
            this.pnlCardLocalApp.Name = "pnlCardLocalApp";
            this.pnlCardLocalApp.Size = new System.Drawing.Size(858, 160);
            this.pnlCardLocalApp.TabIndex = 1;
            // 
            // pnlCardLocalAppHeader
            // 
            this.pnlCardLocalAppHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlCardLocalAppHeader.Controls.Add(this.picCardLocalIcon);
            this.pnlCardLocalAppHeader.Controls.Add(this.lblCardLocalTitle);
            this.pnlCardLocalAppHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardLocalAppHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardLocalAppHeader.Name = "pnlCardLocalAppHeader";
            this.pnlCardLocalAppHeader.Size = new System.Drawing.Size(856, 34);
            this.pnlCardLocalAppHeader.TabIndex = 0;
            // 
            // picCardLocalIcon
            // 
            this.picCardLocalIcon.BackColor = System.Drawing.Color.White;
            this.picCardLocalIcon.Image = global::DVLD.Properties.Resources.ManageApplications;
            this.picCardLocalIcon.Location = new System.Drawing.Point(12, 8);
            this.picCardLocalIcon.Name = "picCardLocalIcon";
            this.picCardLocalIcon.Size = new System.Drawing.Size(18, 18);
            this.picCardLocalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardLocalIcon.TabIndex = 1;
            this.picCardLocalIcon.TabStop = false;
            // 
            // lblCardLocalTitle
            // 
            this.lblCardLocalTitle.AutoSize = true;
            this.lblCardLocalTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardLocalTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardLocalTitle.Location = new System.Drawing.Point(36, 8);
            this.lblCardLocalTitle.Name = "lblCardLocalTitle";
            this.lblCardLocalTitle.Size = new System.Drawing.Size(299, 21);
            this.lblCardLocalTitle.TabIndex = 2;
            this.lblCardLocalTitle.Text = "Local Driving License Application Info";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label16.Location = new System.Drawing.Point(16, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Driving Local Application ID :";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD.Properties.Resources.id;
            this.pictureBox11.Location = new System.Drawing.Point(268, 55);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(18, 18);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // lblLocalAppid
            // 
            this.lblLocalAppid.AutoSize = true;
            this.lblLocalAppid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocalAppid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLocalAppid.Location = new System.Drawing.Point(292, 50);
            this.lblLocalAppid.Name = "lblLocalAppid";
            this.lblLocalAppid.Size = new System.Drawing.Size(43, 23);
            this.lblLocalAppid.TabIndex = 3;
            this.lblLocalAppid.Text = "[???]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label17.Location = new System.Drawing.Point(450, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Passed Tests :";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.PassedTests;
            this.pictureBox12.Location = new System.Drawing.Point(570, 55);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(18, 18);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 5;
            this.pictureBox12.TabStop = false;
            // 
            // lblpassesTests
            // 
            this.lblpassesTests.AutoSize = true;
            this.lblpassesTests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblpassesTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblpassesTests.Location = new System.Drawing.Point(630, 50);
            this.lblpassesTests.Name = "lblpassesTests";
            this.lblpassesTests.Size = new System.Drawing.Size(17, 23);
            this.lblpassesTests.TabIndex = 6;
            this.lblpassesTests.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(620, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "(";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(642, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "/ 3)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label18.Location = new System.Drawing.Point(16, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 21);
            this.label18.TabIndex = 9;
            this.label18.Text = "Applied For License Class :";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DVLD.Properties.Resources.ManageApplications;
            this.pictureBox13.Location = new System.Drawing.Point(268, 101);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(18, 18);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 10;
            this.pictureBox13.TabStop = false;
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLicenseClass.Location = new System.Drawing.Point(292, 96);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(43, 23);
            this.lblLicenseClass.TabIndex = 11;
            this.lblLicenseClass.Text = "[???]";
            // 
            // pnlCardAppInfo
            // 
            this.pnlCardAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCardAppInfo.BackColor = System.Drawing.Color.White;
            this.pnlCardAppInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAppInfo.Controls.Add(this.pnlCardAppHeader);
            this.pnlCardAppInfo.Controls.Add(this.lblSecName);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox6);
            this.pnlCardAppInfo.Controls.Add(this.lblApplicationID);
            this.pnlCardAppInfo.Controls.Add(this.label8);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox3);
            this.pnlCardAppInfo.Controls.Add(this.lblAppStatus);
            this.pnlCardAppInfo.Controls.Add(this.label5);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox10);
            this.pnlCardAppInfo.Controls.Add(this.lblFees);
            this.pnlCardAppInfo.Controls.Add(this.label2);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox1);
            this.pnlCardAppInfo.Controls.Add(this.lblType);
            this.pnlCardAppInfo.Controls.Add(this.label7);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox8);
            this.pnlCardAppInfo.Controls.Add(this.lblApplicant);
            this.pnlCardAppInfo.Controls.Add(this.LinkPersonInfo);
            this.pnlCardAppInfo.Controls.Add(this.label11);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox5);
            this.pnlCardAppInfo.Controls.Add(this.lblDate);
            this.pnlCardAppInfo.Controls.Add(this.label3);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox4);
            this.pnlCardAppInfo.Controls.Add(this.lblStatusDate);
            this.pnlCardAppInfo.Controls.Add(this.label4);
            this.pnlCardAppInfo.Controls.Add(this.pictureBox7);
            this.pnlCardAppInfo.Controls.Add(this.lblCreatedBy);
            this.pnlCardAppInfo.Location = new System.Drawing.Point(16, 272);
            this.pnlCardAppInfo.Name = "pnlCardAppInfo";
            this.pnlCardAppInfo.Size = new System.Drawing.Size(858, 256);
            this.pnlCardAppInfo.TabIndex = 2;
            this.pnlCardAppInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardAppInfo_Paint);
            // 
            // pnlCardAppHeader
            // 
            this.pnlCardAppHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlCardAppHeader.Controls.Add(this.picCardAppIcon);
            this.pnlCardAppHeader.Controls.Add(this.lblCardAppTitle);
            this.pnlCardAppHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardAppHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAppHeader.Name = "pnlCardAppHeader";
            this.pnlCardAppHeader.Size = new System.Drawing.Size(856, 34);
            this.pnlCardAppHeader.TabIndex = 0;
            // 
            // picCardAppIcon
            // 
            this.picCardAppIcon.BackColor = System.Drawing.Color.White;
            this.picCardAppIcon.Image = global::DVLD.Properties.Resources.ApplicationID;
            this.picCardAppIcon.Location = new System.Drawing.Point(12, 7);
            this.picCardAppIcon.Name = "picCardAppIcon";
            this.picCardAppIcon.Size = new System.Drawing.Size(18, 18);
            this.picCardAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardAppIcon.TabIndex = 0;
            this.picCardAppIcon.TabStop = false;
            // 
            // lblCardAppTitle
            // 
            this.lblCardAppTitle.AutoSize = true;
            this.lblCardAppTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCardAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardAppTitle.Location = new System.Drawing.Point(36, 8);
            this.lblCardAppTitle.Name = "lblCardAppTitle";
            this.lblCardAppTitle.Size = new System.Drawing.Size(177, 21);
            this.lblCardAppTitle.TabIndex = 1;
            this.lblCardAppTitle.Text = "Application Basic Info";
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.lblSecName.Location = new System.Drawing.Point(16, 50);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(35, 21);
            this.lblSecName.TabIndex = 1;
            this.lblSecName.Text = "ID :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.ApplicationID;
            this.pictureBox6.Location = new System.Drawing.Point(130, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblApplicationID.Location = new System.Drawing.Point(156, 46);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(43, 23);
            this.lblApplicationID.TabIndex = 3;
            this.lblApplicationID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(16, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Status :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Status;
            this.pictureBox3.Location = new System.Drawing.Point(130, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.AutoSize = true;
            this.lblAppStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblAppStatus.Location = new System.Drawing.Point(156, 90);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(43, 23);
            this.lblAppStatus.TabIndex = 6;
            this.lblAppStatus.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(16, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fees :";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox10.Location = new System.Drawing.Point(130, 138);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(18, 18);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblFees.Location = new System.Drawing.Point(156, 134);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(43, 23);
            this.lblFees.TabIndex = 9;
            this.lblFees.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(16, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ManageApplicationTypes;
            this.pictureBox1.Location = new System.Drawing.Point(130, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblType.Location = new System.Drawing.Point(156, 178);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 23);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(16, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Applicant :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox8.Location = new System.Drawing.Point(130, 226);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(18, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // lblApplicant
            // 
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblApplicant.Location = new System.Drawing.Point(156, 222);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(43, 23);
            this.lblApplicant.TabIndex = 15;
            this.lblApplicant.Text = "[???]";
            // 
            // LinkPersonInfo
            // 
            this.LinkPersonInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkPersonInfo.AutoSize = true;
            this.LinkPersonInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LinkPersonInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkPersonInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(96)))), ((int)(((byte)(165)))));
            this.LinkPersonInfo.Location = new System.Drawing.Point(675, 214);
            this.LinkPersonInfo.Name = "LinkPersonInfo";
            this.LinkPersonInfo.Size = new System.Drawing.Size(157, 21);
            this.LinkPersonInfo.TabIndex = 16;
            this.LinkPersonInfo.TabStop = true;
            this.LinkPersonInfo.Text = "View Person Info →";
            this.LinkPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPersonInfo_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(450, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Date :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox5.Location = new System.Drawing.Point(580, 50);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblDate.Location = new System.Drawing.Point(606, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 23);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(450, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status Date :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox4.Location = new System.Drawing.Point(580, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.AutoSize = true;
            this.lblStatusDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblStatusDate.Location = new System.Drawing.Point(606, 91);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Size = new System.Drawing.Size(43, 23);
            this.lblStatusDate.TabIndex = 22;
            this.lblStatusDate.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(450, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Created By :";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(580, 138);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(606, 135);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(43, 23);
            this.lblCreatedBy.TabIndex = 25;
            this.lblCreatedBy.Text = "[???]";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 534);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(892, 56);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnClose.Location = new System.Drawing.Point(766, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(892, 590);
            this.Controls.Add(this.pnlCardAppInfo);
            this.Controls.Add(this.pnlCardLocalApp);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmShowApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.frmShowApplicationDetails_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlCardLocalApp.ResumeLayout(false);
            this.pnlCardLocalApp.PerformLayout();
            this.pnlCardLocalAppHeader.ResumeLayout(false);
            this.pnlCardLocalAppHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardLocalIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.pnlCardAppInfo.ResumeLayout(false);
            this.pnlCardAppInfo.PerformLayout();
            this.pnlCardAppHeader.ResumeLayout(false);
            this.pnlCardAppHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Panel pnlCardLocalApp;
        private System.Windows.Forms.Panel pnlCardLocalAppHeader;
        private System.Windows.Forms.PictureBox picCardLocalIcon;
        private System.Windows.Forms.Label lblCardLocalTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblLocalAppid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lblpassesTests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Panel pnlCardAppInfo;
        private System.Windows.Forms.Panel pnlCardAppHeader;
        private System.Windows.Forms.PictureBox picCardAppIcon;
        private System.Windows.Forms.Label lblCardAppTitle;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAppStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.LinkLabel LinkPersonInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblStatusDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
    }
}
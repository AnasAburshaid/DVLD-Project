using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmReplacementDrivingLicense
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
            this.pnlHeaderBanner = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.ucDriverLicenseInfoFilter1 = new DVLD.UcDriverLicenseInfoFilter();
            this.LinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LinkShowRenwLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grApplicationRepInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReplacementLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblOldLIcenseID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblRepApplicationID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblSecName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.grReplacementReason = new System.Windows.Forms.GroupBox();
            this.rdLostLicense = new System.Windows.Forms.RadioButton();
            this.rdDamagedLicense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeaderBanner.SuspendLayout();
            this.grApplicationRepInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.grReplacementReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderBanner
            // 
            this.pnlHeaderBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlHeaderBanner.Controls.Add(this.lblFormTitle);
            this.pnlHeaderBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBanner.Name = "pnlHeaderBanner";
            this.pnlHeaderBanner.Size = new System.Drawing.Size(854, 65);
            this.pnlHeaderBanner.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(854, 65);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Replacement for Damaged / Lost License";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDriverLicenseInfoFilter1
            // 
            this.ucDriverLicenseInfoFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucDriverLicenseInfoFilter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucDriverLicenseInfoFilter1.Location = new System.Drawing.Point(0, 70);
            this.ucDriverLicenseInfoFilter1.Name = "ucDriverLicenseInfoFilter1";
            this.ucDriverLicenseInfoFilter1.Size = new System.Drawing.Size(854, 485);
            this.ucDriverLicenseInfoFilter1.TabIndex = 1;
            this.ucDriverLicenseInfoFilter1.OnLicenseFind += new System.Action<int>(this.ucDriverLicenseInfoFilter1_OnLicenseFind);
            // 
            // LinkShowLicenseHistory
            // 
            this.LinkShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowLicenseHistory.AutoSize = true;
            this.LinkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowLicenseHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowLicenseHistory.Location = new System.Drawing.Point(20, 763);
            this.LinkShowLicenseHistory.Name = "LinkShowLicenseHistory";
            this.LinkShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.LinkShowLicenseHistory.TabIndex = 4;
            this.LinkShowLicenseHistory.TabStop = true;
            this.LinkShowLicenseHistory.Text = "Show License History";
            this.LinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkShowLicenseHistory_LinkClicked);
            // 
            // LinkShowRenwLicenseInfo
            // 
            this.LinkShowRenwLicenseInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowRenwLicenseInfo.AutoSize = true;
            this.LinkShowRenwLicenseInfo.Enabled = false;
            this.LinkShowRenwLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowRenwLicenseInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowRenwLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowRenwLicenseInfo.Location = new System.Drawing.Point(210, 763);
            this.LinkShowRenwLicenseInfo.Name = "LinkShowRenwLicenseInfo";
            this.LinkShowRenwLicenseInfo.Size = new System.Drawing.Size(148, 23);
            this.LinkShowRenwLicenseInfo.TabIndex = 5;
            this.LinkShowRenwLicenseInfo.TabStop = true;
            this.LinkShowRenwLicenseInfo.Text = "Show License Info";
            this.LinkShowRenwLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkShowRenwLicenseInfo_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(493, 756);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Issue Replacement";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnClose.Location = new System.Drawing.Point(720, 756);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // grApplicationRepInfo
            // 
            this.grApplicationRepInfo.BackColor = System.Drawing.Color.White;
            this.grApplicationRepInfo.Controls.Add(this.pictureBox1);
            this.grApplicationRepInfo.Controls.Add(this.lblReplacementLicenseID);
            this.grApplicationRepInfo.Controls.Add(this.label9);
            this.grApplicationRepInfo.Controls.Add(this.pictureBox4);
            this.grApplicationRepInfo.Controls.Add(this.lblOldLIcenseID);
            this.grApplicationRepInfo.Controls.Add(this.label4);
            this.grApplicationRepInfo.Controls.Add(this.pictureBox12);
            this.grApplicationRepInfo.Controls.Add(this.lblApplicationFees);
            this.grApplicationRepInfo.Controls.Add(this.label13);
            this.grApplicationRepInfo.Controls.Add(this.lblCreatedBy);
            this.grApplicationRepInfo.Controls.Add(this.lblApplicationDate);
            this.grApplicationRepInfo.Controls.Add(this.lblRepApplicationID);
            this.grApplicationRepInfo.Controls.Add(this.pictureBox6);
            this.grApplicationRepInfo.Controls.Add(this.lblSecName);
            this.grApplicationRepInfo.Controls.Add(this.label8);
            this.grApplicationRepInfo.Controls.Add(this.pictureBox3);
            this.grApplicationRepInfo.Controls.Add(this.label10);
            this.grApplicationRepInfo.Controls.Add(this.pictureBox7);
            this.grApplicationRepInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grApplicationRepInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grApplicationRepInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.grApplicationRepInfo.Location = new System.Drawing.Point(17, 615);
            this.grApplicationRepInfo.Name = "grApplicationRepInfo";
            this.grApplicationRepInfo.Size = new System.Drawing.Size(818, 130);
            this.grApplicationRepInfo.TabIndex = 608;
            this.grApplicationRepInfo.TabStop = false;
            this.grApplicationRepInfo.Text = " Replacement Transaction Specifications ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox1.Location = new System.Drawing.Point(250, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 652;
            this.pictureBox1.TabStop = false;
            // 
            // lblReplacementLicenseID
            // 
            this.lblReplacementLicenseID.AutoSize = true;
            this.lblReplacementLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblReplacementLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblReplacementLicenseID.Location = new System.Drawing.Point(645, 33);
            this.lblReplacementLicenseID.Name = "lblReplacementLicenseID";
            this.lblReplacementLicenseID.Size = new System.Drawing.Size(46, 23);
            this.lblReplacementLicenseID.TabIndex = 651;
            this.lblReplacementLicenseID.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label9.Location = new System.Drawing.Point(460, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 649;
            this.label9.Text = "Replaced Lic. ID :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox4.Location = new System.Drawing.Point(615, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 650;
            this.pictureBox4.TabStop = false;
            // 
            // lblOldLIcenseID
            // 
            this.lblOldLIcenseID.AutoSize = true;
            this.lblOldLIcenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOldLIcenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblOldLIcenseID.Location = new System.Drawing.Point(645, 64);
            this.lblOldLIcenseID.Name = "lblOldLIcenseID";
            this.lblOldLIcenseID.Size = new System.Drawing.Size(46, 23);
            this.lblOldLIcenseID.TabIndex = 648;
            this.lblOldLIcenseID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(460, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 646;
            this.label4.Text = "Old License ID   :";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox12.Location = new System.Drawing.Point(615, 66);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 647;
            this.pictureBox12.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(280, 93);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(46, 23);
            this.lblApplicationFees.TabIndex = 638;
            this.lblApplicationFees.Text = "[???]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label13.Location = new System.Drawing.Point(14, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 23);
            this.label13.TabIndex = 637;
            this.label13.Text = "Application Fees";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(645, 95);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 23);
            this.lblCreatedBy.TabIndex = 630;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblApplicationDate.Location = new System.Drawing.Point(280, 64);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(46, 23);
            this.lblApplicationDate.TabIndex = 627;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblRepApplicationID
            // 
            this.lblRepApplicationID.AutoSize = true;
            this.lblRepApplicationID.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblRepApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblRepApplicationID.Location = new System.Drawing.Point(280, 32);
            this.lblRepApplicationID.Name = "lblRepApplicationID";
            this.lblRepApplicationID.Size = new System.Drawing.Size(28, 25);
            this.lblRepApplicationID.TabIndex = 626;
            this.lblRepApplicationID.Text = "--";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DVLD.Properties.Resources.ApplicationID;
            this.pictureBox6.Location = new System.Drawing.Point(250, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 625;
            this.pictureBox6.TabStop = false;
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblSecName.Location = new System.Drawing.Point(14, 34);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(167, 23);
            this.lblSecName.TabIndex = 624;
            this.lblSecName.Text = "Rep. Application ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(14, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 622;
            this.label8.Text = "Application Date";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(250, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 623;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(460, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 618;
            this.label10.Text = "Created By ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(615, 95);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 621;
            this.pictureBox7.TabStop = false;
            // 
            // grReplacementReason
            // 
            this.grReplacementReason.BackColor = System.Drawing.Color.White;
            this.grReplacementReason.Controls.Add(this.rdLostLicense);
            this.grReplacementReason.Controls.Add(this.rdDamagedLicense);
            this.grReplacementReason.Controls.Add(this.label1);
            this.grReplacementReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grReplacementReason.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grReplacementReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.grReplacementReason.Location = new System.Drawing.Point(17, 540);
            this.grReplacementReason.Name = "grReplacementReason";
            this.grReplacementReason.Size = new System.Drawing.Size(818, 66);
            this.grReplacementReason.TabIndex = 609;
            this.grReplacementReason.TabStop = false;
            this.grReplacementReason.Text = " Replacement Reason ";
            // 
            // rdLostLicense
            // 
            this.rdLostLicense.AutoSize = true;
            this.rdLostLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdLostLicense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdLostLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.rdLostLicense.Location = new System.Drawing.Point(380, 28);
            this.rdLostLicense.Name = "rdLostLicense";
            this.rdLostLicense.Size = new System.Drawing.Size(126, 27);
            this.rdLostLicense.TabIndex = 1;
            this.rdLostLicense.TabStop = true;
            this.rdLostLicense.Text = "Lost License";
            this.rdLostLicense.UseVisualStyleBackColor = true;
            this.rdLostLicense.CheckedChanged += new System.EventHandler(this.rdLostLicense_CheckedChanged);
            // 
            // rdDamagedLicense
            // 
            this.rdDamagedLicense.AutoSize = true;
            this.rdDamagedLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdDamagedLicense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdDamagedLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.rdDamagedLicense.Location = new System.Drawing.Point(200, 28);
            this.rdDamagedLicense.Name = "rdDamagedLicense";
            this.rdDamagedLicense.Size = new System.Drawing.Size(171, 27);
            this.rdDamagedLicense.TabIndex = 0;
            this.rdDamagedLicense.TabStop = true;
            this.rdDamagedLicense.Text = "Damaged License";
            this.rdDamagedLicense.UseVisualStyleBackColor = true;
            this.rdDamagedLicense.CheckedChanged += new System.EventHandler(this.rdDamagedLicense_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 638;
            this.label1.Text = "Replacement For :";
            // 
            // frmReplacementDrivingLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(854, 805);
            this.Controls.Add(this.grReplacementReason);
            this.Controls.Add(this.grApplicationRepInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LinkShowRenwLicenseInfo);
            this.Controls.Add(this.ucDriverLicenseInfoFilter1);
            this.Controls.Add(this.LinkShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReplacementDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enforcement Terminal: Driving Document Replacement Center";
            this.Load += new System.EventHandler(this.frmReplacementDrivingLicense_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            this.grApplicationRepInfo.ResumeLayout(false);
            this.grApplicationRepInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.grReplacementReason.ResumeLayout(false);
            this.grReplacementReason.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label lblFormTitle;
        private UcDriverLicenseInfoFilter ucDriverLicenseInfoFilter1;
        private System.Windows.Forms.LinkLabel LinkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel LinkShowRenwLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private GroupBox grApplicationRepInfo;
        private PictureBox pictureBox1;
        private Label lblReplacementLicenseID;
        private Label label9;
        private PictureBox pictureBox4;
        private Label lblOldLIcenseID;
        private Label label4;
        private PictureBox pictureBox12;
        private Label lblApplicationFees;
        private Label label13;
        private Label lblCreatedBy;
        private Label lblApplicationDate;
        private Label lblRepApplicationID;
        private PictureBox pictureBox6;
        private Label lblSecName;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox7;
        private GroupBox grReplacementReason;
        private RadioButton rdLostLicense;
        private RadioButton rdDamagedLicense;
        private Label label1;
    }
}
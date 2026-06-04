using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmReleaseDetainedLicense
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
            this.LinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LinkShowReleasedLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grDetainApplicationInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblSecName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ucDriverLicenseInfoFilter1 = new DVLD.UcDriverLicenseInfoFilter();
            this.pnlHeaderBanner.SuspendLayout();
            this.grDetainApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            this.lblFormTitle.Text = "Release Detained Driver License System";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkShowLicenseHistory
            // 
            this.LinkShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowLicenseHistory.AutoSize = true;
            this.LinkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowLicenseHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowLicenseHistory.Location = new System.Drawing.Point(20, 703);
            this.LinkShowLicenseHistory.Name = "LinkShowLicenseHistory";
            this.LinkShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.LinkShowLicenseHistory.TabIndex = 3;
            this.LinkShowLicenseHistory.TabStop = true;
            this.LinkShowLicenseHistory.Text = "Show License History";
            this.LinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkShowLicenseHistory_LinkClicked);
            // 
            // LinkShowReleasedLicenseInfo
            // 
            this.LinkShowReleasedLicenseInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowReleasedLicenseInfo.AutoSize = true;
            this.LinkShowReleasedLicenseInfo.Enabled = false;
            this.LinkShowReleasedLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowReleasedLicenseInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowReleasedLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowReleasedLicenseInfo.Location = new System.Drawing.Point(210, 703);
            this.LinkShowReleasedLicenseInfo.Name = "LinkShowReleasedLicenseInfo";
            this.LinkShowReleasedLicenseInfo.Size = new System.Drawing.Size(221, 23);
            this.LinkShowReleasedLicenseInfo.TabIndex = 4;
            this.LinkShowReleasedLicenseInfo.TabStop = true;
            this.LinkShowReleasedLicenseInfo.Text = "Show Released License Info";
            this.LinkShowReleasedLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkShowReleasedLicenseInfo_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(545, 696);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Release";
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
            this.btnClose.Location = new System.Drawing.Point(705, 696);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grDetainApplicationInfo
            // 
            this.grDetainApplicationInfo.BackColor = System.Drawing.Color.White;
            this.grDetainApplicationInfo.Controls.Add(this.label1);
            this.grDetainApplicationInfo.Controls.Add(this.lblTotalFees);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox8);
            this.grDetainApplicationInfo.Controls.Add(this.label7);
            this.grDetainApplicationInfo.Controls.Add(this.lblAppID);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox5);
            this.grDetainApplicationInfo.Controls.Add(this.label4);
            this.grDetainApplicationInfo.Controls.Add(this.lblFineFees);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox2);
            this.grDetainApplicationInfo.Controls.Add(this.label3);
            this.grDetainApplicationInfo.Controls.Add(this.lblAppFees);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox1);
            this.grDetainApplicationInfo.Controls.Add(this.lblLicenseID);
            this.grDetainApplicationInfo.Controls.Add(this.label9);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox4);
            this.grDetainApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.grDetainApplicationInfo.Controls.Add(this.lblDetainDate);
            this.grDetainApplicationInfo.Controls.Add(this.lblDetainID);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox6);
            this.grDetainApplicationInfo.Controls.Add(this.lblSecName);
            this.grDetainApplicationInfo.Controls.Add(this.label8);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox3);
            this.grDetainApplicationInfo.Controls.Add(this.label10);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox7);
            this.grDetainApplicationInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grDetainApplicationInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grDetainApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.grDetainApplicationInfo.Location = new System.Drawing.Point(12, 539);
            this.grDetainApplicationInfo.Name = "grDetainApplicationInfo";
            this.grDetainApplicationInfo.Size = new System.Drawing.Size(818, 148);
            this.grDetainApplicationInfo.TabIndex = 625;
            this.grDetainApplicationInfo.TabStop = false;
            this.grDetainApplicationInfo.Text = " Release Transaction Specifications ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 661;
            this.label1.Text = "Application Fees";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Black", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblTotalFees.Location = new System.Drawing.Point(546, 112);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(52, 25);
            this.lblTotalFees.TabIndex = 23;
            this.lblTotalFees.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox8.Location = new System.Drawing.Point(516, 115);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 660;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label7.Location = new System.Drawing.Point(365, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Fees Center";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblAppID.Location = new System.Drawing.Point(546, 36);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(46, 23);
            this.lblAppID.TabIndex = 7;
            this.lblAppID.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox5.Location = new System.Drawing.Point(516, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 657;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(365, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Application ID";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFineFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblFineFees.Location = new System.Drawing.Point(193, 114);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(46, 23);
            this.lblFineFees.TabIndex = 17;
            this.lblFineFees.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox2.Location = new System.Drawing.Point(163, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 655;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fine Fees center";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblAppFees.Location = new System.Drawing.Point(193, 90);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(46, 23);
            this.lblAppFees.TabIndex = 14;
            this.lblAppFees.Text = "[???]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox1.Location = new System.Drawing.Point(163, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 652;
            this.pictureBox1.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLicenseID.Location = new System.Drawing.Point(546, 62);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(46, 23);
            this.lblLicenseID.TabIndex = 12;
            this.lblLicenseID.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label9.Location = new System.Drawing.Point(365, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "License ID";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox4.Location = new System.Drawing.Point(516, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 650;
            this.pictureBox4.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(546, 88);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 23);
            this.lblCreatedBy.TabIndex = 15;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetainDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblDetainDate.Location = new System.Drawing.Point(193, 64);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(46, 23);
            this.lblDetainDate.TabIndex = 10;
            this.lblDetainDate.Text = "[???]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblDetainID.Location = new System.Drawing.Point(193, 32);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(28, 25);
            this.lblDetainID.TabIndex = 2;
            this.lblDetainID.Text = "--";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.detianID;
            this.pictureBox6.Location = new System.Drawing.Point(163, 36);
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
            this.lblSecName.Location = new System.Drawing.Point(14, 36);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(91, 23);
            this.lblSecName.TabIndex = 1;
            this.lblSecName.Text = "Detain ID ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(14, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Detain Date";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(163, 66);
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
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label10.Location = new System.Drawing.Point(365, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Created By";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(516, 90);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 621;
            this.pictureBox7.TabStop = false;
            // 
            // ucDriverLicenseInfoFilter1
            // 
            this.ucDriverLicenseInfoFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucDriverLicenseInfoFilter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucDriverLicenseInfoFilter1.Location = new System.Drawing.Point(0, 70);
            this.ucDriverLicenseInfoFilter1.Name = "ucDriverLicenseInfoFilter1";
            this.ucDriverLicenseInfoFilter1.Size = new System.Drawing.Size(854, 484);
            this.ucDriverLicenseInfoFilter1.TabIndex = 1;
            this.ucDriverLicenseInfoFilter1.OnLicenseFind += new System.Action<int>(this.ucDriverLicenseInfoFilter1_OnLicenseFind);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(854, 736);
            this.Controls.Add(this.grDetainApplicationInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LinkShowReleasedLicenseInfo);
            this.Controls.Add(this.ucDriverLicenseInfoFilter1);
            this.Controls.Add(this.LinkShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Government License Enforcement Center — Asset Release Portal";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            this.grDetainApplicationInfo.ResumeLayout(false);
            this.grDetainApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label lblFormTitle;
        private UcDriverLicenseInfoFilter ucDriverLicenseInfoFilter1;
        private System.Windows.Forms.LinkLabel LinkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel LinkShowReleasedLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private GroupBox grDetainApplicationInfo;
        private Label lblTotalFees;
        private PictureBox pictureBox8;
        private Label label7;
        private Label lblAppID;
        private PictureBox pictureBox5;
        private Label label4;
        private Label lblFineFees;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lblAppFees;
        private PictureBox pictureBox1;
        private Label lblLicenseID;
        private Label label9;
        private PictureBox pictureBox4;
        private Label lblCreatedBy;
        private Label lblDetainDate;
        private Label lblDetainID;
        private PictureBox pictureBox6;
        private Label lblSecName;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox7;
        private Label label1;
    }
}
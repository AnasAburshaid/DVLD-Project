using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmRenewDrivingLicense
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
            this.btnClose = new System.Windows.Forms.Button();
            this.LinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LinkShowRenwLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.grApplicationInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSecName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRenewLicenseId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblRenewApplicationID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderBanner.SuspendLayout();
            this.grApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.lblFormTitle.Text = "Renew Driving License Workspace";
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnClose.Location = new System.Drawing.Point(697, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LinkShowLicenseHistory
            // 
            this.LinkShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowLicenseHistory.AutoSize = true;
            this.LinkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowLicenseHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowLicenseHistory.Location = new System.Drawing.Point(12, 768);
            this.LinkShowLicenseHistory.Name = "LinkShowLicenseHistory";
            this.LinkShowLicenseHistory.Size = new System.Drawing.Size(173, 23);
            this.LinkShowLicenseHistory.TabIndex = 3;
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
            this.LinkShowRenwLicenseInfo.Location = new System.Drawing.Point(202, 768);
            this.LinkShowRenwLicenseInfo.Name = "LinkShowRenwLicenseInfo";
            this.LinkShowRenwLicenseInfo.Size = new System.Drawing.Size(148, 23);
            this.LinkShowRenwLicenseInfo.TabIndex = 4;
            this.LinkShowRenwLicenseInfo.TabStop = true;
            this.LinkShowRenwLicenseInfo.Text = "Show License Info";
            this.LinkShowRenwLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkShowLicenseInfo_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(537, 761);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Renew";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grApplicationInfo
            // 
            this.grApplicationInfo.BackColor = System.Drawing.Color.White;
            this.grApplicationInfo.Controls.Add(this.label2);
            this.grApplicationInfo.Controls.Add(this.label13);
            this.grApplicationInfo.Controls.Add(this.lblSecName);
            this.grApplicationInfo.Controls.Add(this.label8);
            this.grApplicationInfo.Controls.Add(this.label6);
            this.grApplicationInfo.Controls.Add(this.lblRenewLicenseId);
            this.grApplicationInfo.Controls.Add(this.label9);
            this.grApplicationInfo.Controls.Add(this.pictureBox4);
            this.grApplicationInfo.Controls.Add(this.lblLicenseFees);
            this.grApplicationInfo.Controls.Add(this.label4);
            this.grApplicationInfo.Controls.Add(this.pictureBox12);
            this.grApplicationInfo.Controls.Add(this.lblTotalFees);
            this.grApplicationInfo.Controls.Add(this.label3);
            this.grApplicationInfo.Controls.Add(this.pictureBox8);
            this.grApplicationInfo.Controls.Add(this.txtNotes);
            this.grApplicationInfo.Controls.Add(this.pictureBox1);
            this.grApplicationInfo.Controls.Add(this.pictureBox9);
            this.grApplicationInfo.Controls.Add(this.lblIssueDate);
            this.grApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.grApplicationInfo.Controls.Add(this.label11);
            this.grApplicationInfo.Controls.Add(this.pictureBox5);
            this.grApplicationInfo.Controls.Add(this.lblExpDate);
            this.grApplicationInfo.Controls.Add(this.label18);
            this.grApplicationInfo.Controls.Add(this.pictureBox13);
            this.grApplicationInfo.Controls.Add(this.lblLocalLicenseID);
            this.grApplicationInfo.Controls.Add(this.lblFees);
            this.grApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.grApplicationInfo.Controls.Add(this.lblRenewApplicationID);
            this.grApplicationInfo.Controls.Add(this.pictureBox6);
            this.grApplicationInfo.Controls.Add(this.pictureBox3);
            this.grApplicationInfo.Controls.Add(this.pictureBox2);
            this.grApplicationInfo.Controls.Add(this.label10);
            this.grApplicationInfo.Controls.Add(this.pictureBox7);
            this.grApplicationInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grApplicationInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grApplicationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.grApplicationInfo.Location = new System.Drawing.Point(16, 552);
            this.grApplicationInfo.Name = "grApplicationInfo";
            this.grApplicationInfo.Size = new System.Drawing.Size(820, 194);
            this.grApplicationInfo.TabIndex = 596;
            this.grApplicationInfo.TabStop = false;
            this.grApplicationInfo.Text = " Application New License Specifications ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 656;
            this.label2.Text = "Notes  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label13.Location = new System.Drawing.Point(6, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 655;
            this.label13.Text = "Issue Date  :";
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblSecName.Location = new System.Drawing.Point(6, 33);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(142, 23);
            this.lblSecName.TabIndex = 652;
            this.lblSecName.Text = "R.Application ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 653;
            this.label8.Text = "Application Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 654;
            this.label6.Text = "Applicaion Fees";
            // 
            // lblRenewLicenseId
            // 
            this.lblRenewLicenseId.AutoSize = true;
            this.lblRenewLicenseId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewLicenseId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblRenewLicenseId.Location = new System.Drawing.Point(658, 33);
            this.lblRenewLicenseId.Name = "lblRenewLicenseId";
            this.lblRenewLicenseId.Size = new System.Drawing.Size(46, 23);
            this.lblRenewLicenseId.TabIndex = 651;
            this.lblRenewLicenseId.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label9.Location = new System.Drawing.Point(466, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 649;
            this.label9.Text = "Renewed Lic. ID  :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox4.Location = new System.Drawing.Point(628, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 650;
            this.pictureBox4.TabStop = false;
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLicenseFees.Location = new System.Drawing.Point(658, 61);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(46, 23);
            this.lblLicenseFees.TabIndex = 648;
            this.lblLicenseFees.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(466, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 646;
            this.label4.Text = "License Fees  :";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox12.Location = new System.Drawing.Point(628, 63);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 647;
            this.pictureBox12.TabStop = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblTotalFees.Location = new System.Drawing.Point(658, 117);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(52, 25);
            this.lblTotalFees.TabIndex = 645;
            this.lblTotalFees.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(466, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 643;
            this.label3.Text = "Total Fees  :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox8.Location = new System.Drawing.Point(628, 119);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 644;
            this.pictureBox8.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.txtNotes.Location = new System.Drawing.Point(189, 148);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(250, 39);
            this.txtNotes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Notes;
            this.pictureBox1.Location = new System.Drawing.Point(159, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 641;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox9.Location = new System.Drawing.Point(159, 91);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 639;
            this.pictureBox9.TabStop = false;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblIssueDate.Location = new System.Drawing.Point(189, 89);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(46, 23);
            this.lblIssueDate.TabIndex = 638;
            this.lblIssueDate.Text = "[???]";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(658, 145);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 23);
            this.lblCreatedBy.TabIndex = 636;
            this.lblCreatedBy.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label11.Location = new System.Drawing.Point(466, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 634;
            this.label11.Text = "Created By  :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox5.Location = new System.Drawing.Point(628, 147);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 635;
            this.pictureBox5.TabStop = false;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblExpDate.Location = new System.Drawing.Point(658, 89);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(46, 23);
            this.lblExpDate.TabIndex = 633;
            this.lblExpDate.Text = "[???]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label18.Location = new System.Drawing.Point(466, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 631;
            this.label18.Text = "Expiration Date:";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox13.Location = new System.Drawing.Point(628, 91);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 20);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 632;
            this.pictureBox13.TabStop = false;
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLocalLicenseID.Location = new System.Drawing.Point(420, -50);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(46, 23);
            this.lblLocalLicenseID.TabIndex = 630;
            this.lblLocalLicenseID.Text = "[???]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblFees.Location = new System.Drawing.Point(189, 117);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(46, 23);
            this.lblFees.TabIndex = 628;
            this.lblFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblApplicationDate.Location = new System.Drawing.Point(189, 61);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(46, 23);
            this.lblApplicationDate.TabIndex = 627;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblRenewApplicationID
            // 
            this.lblRenewApplicationID.AutoSize = true;
            this.lblRenewApplicationID.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblRenewApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblRenewApplicationID.Location = new System.Drawing.Point(189, 31);
            this.lblRenewApplicationID.Name = "lblRenewApplicationID";
            this.lblRenewApplicationID.Size = new System.Drawing.Size(28, 25);
            this.lblRenewApplicationID.TabIndex = 2;
            this.lblRenewApplicationID.Text = "--";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DVLD.Properties.Resources.ApplicationID;
            this.pictureBox6.Location = new System.Drawing.Point(159, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 625;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(159, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 623;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox2.Location = new System.Drawing.Point(159, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 620;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(465, -50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 23);
            this.label10.TabIndex = 618;
            this.label10.Text = "Local License ID";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox7.Location = new System.Drawing.Point(390, -52);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 621;
            this.pictureBox7.TabStop = false;
            // 
            // frmRenewDrivingLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(854, 800);
            this.Controls.Add(this.grApplicationInfo);
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
            this.Name = "frmRenewDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Government License Issuance Terminal — Renewal Workspace";
            this.pnlHeaderBanner.ResumeLayout(false);
            this.grApplicationInfo.ResumeLayout(false);
            this.grApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label lblFormTitle;
        private UcDriverLicenseInfoFilter ucDriverLicenseInfoFilter1;
        private Button btnClose;
        private LinkLabel LinkShowLicenseHistory;
        private LinkLabel LinkShowRenwLicenseInfo;
        private Button btnSave;
        private GroupBox grApplicationInfo;
        private Label label2;
        private Label label13;
        private Label lblSecName;
        private Label label8;
        private Label label6;
        private Label lblRenewLicenseId;
        private Label label9;
        private PictureBox pictureBox4;
        private Label lblLicenseFees;
        private Label label4;
        private PictureBox pictureBox12;
        private Label lblTotalFees;
        private Label label3;
        private PictureBox pictureBox8;
        private TextBox txtNotes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private Label lblIssueDate;
        private Label lblCreatedBy;
        private Label label11;
        private PictureBox pictureBox5;
        private Label lblExpDate;
        private Label label18;
        private PictureBox pictureBox13;
        private Label lblLocalLicenseID;
        private Label lblFees;
        private Label lblApplicationDate;
        private Label lblRenewApplicationID;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label10;
        private PictureBox pictureBox7;
    }
}
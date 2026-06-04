using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmAddEditTestAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.ppTestType = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAppIdTag = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseID = new System.Windows.Forms.Label();
            this.pnlDiv1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLicenseClassType = new System.Windows.Forms.Label();
            this.pnlDiv2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlDiv3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrail = new System.Windows.Forms.Label();
            this.pnlDiv4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTestDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.gbRetakeTes = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRetakeFees = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRetakeTestApplication = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeaderBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppTestType)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.gbRetakeTes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderBanner
            // 
            this.pnlHeaderBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlHeaderBanner.Controls.Add(this.label1);
            this.pnlHeaderBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBanner.Name = "pnlHeaderBanner";
            this.pnlHeaderBanner.Size = new System.Drawing.Size(703, 65);
            this.pnlHeaderBanner.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Test Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ppTestType
            // 
            this.ppTestType.Image = global::DVLD.Properties.Resources.VisionTest2;
            this.ppTestType.Location = new System.Drawing.Point(192, 79);
            this.ppTestType.Name = "ppTestType";
            this.ppTestType.Size = new System.Drawing.Size(309, 114);
            this.ppTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ppTestType.TabIndex = 1;
            this.ppTestType.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox12);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAppIdTag);
            this.pnlHeader.Controls.Add(this.lblLocalDrivingLicenseID);
            this.pnlHeader.Location = new System.Drawing.Point(80, 205);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(540, 60);
            this.pnlHeader.TabIndex = 2;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::DVLD.Properties.Resources.NewDrivingLicense;
            this.pictureBox12.Location = new System.Drawing.Point(16, 18);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 23);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblTitle.Location = new System.Drawing.Point(44, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "D.L.App.ID";
            // 
            // lblAppIdTag
            // 
            this.lblAppIdTag.AutoSize = true;
            this.lblAppIdTag.Font = new System.Drawing.Font("Segoe UI Black", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblAppIdTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblAppIdTag.Location = new System.Drawing.Point(362, 11);
            this.lblAppIdTag.Name = "lblAppIdTag";
            this.lblAppIdTag.Size = new System.Drawing.Size(84, 17);
            this.lblAppIdTag.TabIndex = 2;
            this.lblAppIdTag.Text = "D.L. APP ID";
            // 
            // lblLocalDrivingLicenseID
            // 
            this.lblLocalDrivingLicenseID.AutoSize = true;
            this.lblLocalDrivingLicenseID.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblLocalDrivingLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLocalDrivingLicenseID.Location = new System.Drawing.Point(362, 29);
            this.lblLocalDrivingLicenseID.Name = "lblLocalDrivingLicenseID";
            this.lblLocalDrivingLicenseID.Size = new System.Drawing.Size(52, 25);
            this.lblLocalDrivingLicenseID.TabIndex = 3;
            this.lblLocalDrivingLicenseID.Text = "[???]";
            // 
            // pnlDiv1
            // 
            this.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlDiv1.Location = new System.Drawing.Point(80, 280);
            this.pnlDiv1.Name = "pnlDiv1";
            this.pnlDiv1.Size = new System.Drawing.Size(540, 1);
            this.pnlDiv1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Details;
            this.pictureBox3.Location = new System.Drawing.Point(93, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label8.Location = new System.Drawing.Point(123, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "LICENSE CLASS";
            // 
            // lblLicenseClassType
            // 
            this.lblLicenseClassType.AutoSize = true;
            this.lblLicenseClassType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClassType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLicenseClassType.Location = new System.Drawing.Point(283, 291);
            this.lblLicenseClassType.Name = "lblLicenseClassType";
            this.lblLicenseClassType.Size = new System.Drawing.Size(46, 23);
            this.lblLicenseClassType.TabIndex = 6;
            this.lblLicenseClassType.Text = "[???]";
            // 
            // pnlDiv2
            // 
            this.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlDiv2.Location = new System.Drawing.Point(80, 325);
            this.pnlDiv2.Name = "pnlDiv2";
            this.pnlDiv2.Size = new System.Drawing.Size(540, 1);
            this.pnlDiv2.TabIndex = 7;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.Username2;
            this.pictureBox6.Location = new System.Drawing.Point(93, 338);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(123, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "APPLICANT NAME";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblName.Location = new System.Drawing.Point(283, 336);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 23);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "[???]";
            // 
            // pnlDiv3
            // 
            this.pnlDiv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlDiv3.Location = new System.Drawing.Point(80, 370);
            this.pnlDiv3.Name = "pnlDiv3";
            this.pnlDiv3.Size = new System.Drawing.Size(540, 1);
            this.pnlDiv3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.trail;
            this.pictureBox2.Location = new System.Drawing.Point(93, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(123, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "TRIAL NO.";
            // 
            // lblTrail
            // 
            this.lblTrail.AutoSize = true;
            this.lblTrail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblTrail.Location = new System.Drawing.Point(283, 381);
            this.lblTrail.Name = "lblTrail";
            this.lblTrail.Size = new System.Drawing.Size(46, 23);
            this.lblTrail.TabIndex = 14;
            this.lblTrail.Text = "[???]";
            // 
            // pnlDiv4
            // 
            this.pnlDiv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlDiv4.Location = new System.Drawing.Point(80, 415);
            this.pnlDiv4.Name = "pnlDiv4";
            this.pnlDiv4.Size = new System.Drawing.Size(540, 1);
            this.pnlDiv4.TabIndex = 15;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox5.Location = new System.Drawing.Point(93, 428);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label9.Location = new System.Drawing.Point(123, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "TEST DATE";
            // 
            // dtTestDate
            // 
            this.dtTestDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.dtTestDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtTestDate.Location = new System.Drawing.Point(283, 423);
            this.dtTestDate.Name = "dtTestDate";
            this.dtTestDate.Size = new System.Drawing.Size(300, 30);
            this.dtTestDate.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.panel1.Location = new System.Drawing.Point(80, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 1);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox7.Location = new System.Drawing.Point(93, 473);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label11.Location = new System.Drawing.Point(123, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "FEES";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblFees.Location = new System.Drawing.Point(283, 471);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(48, 25);
            this.lblFees.TabIndex = 22;
            this.lblFees.Text = "[???]";
            // 
            // gbRetakeTes
            // 
            this.gbRetakeTes.BackColor = System.Drawing.Color.White;
            this.gbRetakeTes.Controls.Add(this.pictureBox4);
            this.gbRetakeTes.Controls.Add(this.label6);
            this.gbRetakeTes.Controls.Add(this.lblRetakeFees);
            this.gbRetakeTes.Controls.Add(this.pictureBox8);
            this.gbRetakeTes.Controls.Add(this.label13);
            this.gbRetakeTes.Controls.Add(this.lblTotalFees);
            this.gbRetakeTes.Controls.Add(this.pictureBox9);
            this.gbRetakeTes.Controls.Add(this.label15);
            this.gbRetakeTes.Controls.Add(this.lblRetakeTestApplication);
            this.gbRetakeTes.Enabled = false;
            this.gbRetakeTes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.gbRetakeTes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.gbRetakeTes.Location = new System.Drawing.Point(80, 515);
            this.gbRetakeTes.Name = "gbRetakeTes";
            this.gbRetakeTes.Size = new System.Drawing.Size(540, 115);
            this.gbRetakeTes.TabIndex = 23;
            this.gbRetakeTes.TabStop = false;
            this.gbRetakeTes.Text = " Retake Test Info ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox4.Location = new System.Drawing.Point(14, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(40, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "R. APP FEES:";
            // 
            // lblRetakeFees
            // 
            this.lblRetakeFees.AutoSize = true;
            this.lblRetakeFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRetakeFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblRetakeFees.Location = new System.Drawing.Point(155, 36);
            this.lblRetakeFees.Name = "lblRetakeFees";
            this.lblRetakeFees.Size = new System.Drawing.Size(46, 23);
            this.lblRetakeFees.TabIndex = 2;
            this.lblRetakeFees.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox8.Location = new System.Drawing.Point(280, 38);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label13.Location = new System.Drawing.Point(306, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "TOTAL FEES:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblTotalFees.Location = new System.Drawing.Point(420, 36);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(46, 23);
            this.lblTotalFees.TabIndex = 5;
            this.lblTotalFees.Text = "[???]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD.Properties.Resources.NewDrivingLicense;
            this.pictureBox9.Location = new System.Drawing.Point(14, 75);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.label15.Location = new System.Drawing.Point(40, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "R.TEST APP ID:";
            // 
            // lblRetakeTestApplication
            // 
            this.lblRetakeTestApplication.AutoSize = true;
            this.lblRetakeTestApplication.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRetakeTestApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblRetakeTestApplication.Location = new System.Drawing.Point(155, 73);
            this.lblRetakeTestApplication.Name = "lblRetakeTestApplication";
            this.lblRetakeTestApplication.Size = new System.Drawing.Size(46, 23);
            this.lblRetakeTestApplication.TabIndex = 8;
            this.lblRetakeTestApplication.Text = "[???]";
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
            this.btnSave.Location = new System.Drawing.Point(365, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "✔  Save";
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
            this.btnClose.Location = new System.Drawing.Point(500, 655);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditTestAppointment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(703, 716);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRetakeTes);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtTestDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnlDiv4);
            this.Controls.Add(this.lblTrail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlDiv3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pnlDiv2);
            this.Controls.Add(this.lblLicenseClassType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pnlDiv1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.ppTestType);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Scheduling Command System";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppTestType)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.gbRetakeTes.ResumeLayout(false);
            this.gbRetakeTes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ppTestType;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAppIdTag;
        private System.Windows.Forms.Label lblLocalDrivingLicenseID;
        private System.Windows.Forms.Panel pnlDiv1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLicenseClassType;
        private System.Windows.Forms.Panel pnlDiv2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlDiv3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrail;
        private System.Windows.Forms.Panel pnlDiv4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTestDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.GroupBox gbRetakeTes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRetakeFees;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRetakeTestApplication;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
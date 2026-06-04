using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmDetainLicense
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
            this.pnlInfoBorder = new System.Windows.Forms.Panel();
            this.grDetainApplicationInfo = new System.Windows.Forms.GroupBox();
            this.numFineFees = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblSecName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.LinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LinkShowRenwLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeaderBanner.SuspendLayout();
            this.pnlInfoBorder.SuspendLayout();
            this.grDetainApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFineFees)).BeginInit();
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
            this.lblFormTitle.Text = "Detain Driver License System Workspace";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDriverLicenseInfoFilter1
            // 
            this.ucDriverLicenseInfoFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucDriverLicenseInfoFilter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucDriverLicenseInfoFilter1.Location = new System.Drawing.Point(0, 70);
            this.ucDriverLicenseInfoFilter1.Name = "ucDriverLicenseInfoFilter1";
            this.ucDriverLicenseInfoFilter1.Size = new System.Drawing.Size(854, 458);
            this.ucDriverLicenseInfoFilter1.TabIndex = 1;
            this.ucDriverLicenseInfoFilter1.OnLicenseFind += new System.Action<int>(this.ucDriverLicenseInfoFilter1_OnLicenseFind);
            // 
            // pnlInfoBorder
            // 
            this.pnlInfoBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlInfoBorder.Controls.Add(this.grDetainApplicationInfo);
            this.pnlInfoBorder.Location = new System.Drawing.Point(15, 528);
            this.pnlInfoBorder.Name = "pnlInfoBorder";
            this.pnlInfoBorder.Size = new System.Drawing.Size(820, 150);
            this.pnlInfoBorder.TabIndex = 2;
            // 
            // grDetainApplicationInfo
            // 
            this.grDetainApplicationInfo.BackColor = System.Drawing.Color.White;
            this.grDetainApplicationInfo.Controls.Add(this.numFineFees);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox1);
            this.grDetainApplicationInfo.Controls.Add(this.lblLicenseID);
            this.grDetainApplicationInfo.Controls.Add(this.label9);
            this.grDetainApplicationInfo.Controls.Add(this.pictureBox4);
            this.grDetainApplicationInfo.Controls.Add(this.label13);
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
            this.grDetainApplicationInfo.Location = new System.Drawing.Point(1, 1);
            this.grDetainApplicationInfo.Name = "grDetainApplicationInfo";
            this.grDetainApplicationInfo.Size = new System.Drawing.Size(818, 148);
            this.grDetainApplicationInfo.TabIndex = 0;
            this.grDetainApplicationInfo.TabStop = false;
            this.grDetainApplicationInfo.Text = " Detain Transaction Specifications ";
            // 
            // numFineFees
            // 
            this.numFineFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.numFineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numFineFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numFineFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.numFineFees.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFineFees.Location = new System.Drawing.Point(160, 100);
            this.numFineFees.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numFineFees.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFineFees.Name = "numFineFees";
            this.numFineFees.Size = new System.Drawing.Size(140, 30);
            this.numFineFees.TabIndex = 2;
            this.numFineFees.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Fees;
            this.pictureBox1.Location = new System.Drawing.Point(130, 105);
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
            this.lblLicenseID.Location = new System.Drawing.Point(515, 36);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(46, 23);
            this.lblLicenseID.TabIndex = 651;
            this.lblLicenseID.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label9.Location = new System.Drawing.Point(365, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 649;
            this.label9.Text = "License ID";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox4.Location = new System.Drawing.Point(485, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 650;
            this.pictureBox4.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label13.Location = new System.Drawing.Point(14, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 23);
            this.label13.TabIndex = 637;
            this.label13.Text = "Fine Fees";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(515, 68);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(46, 23);
            this.lblCreatedBy.TabIndex = 630;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetainDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblDetainDate.Location = new System.Drawing.Point(160, 68);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(46, 23);
            this.lblDetainDate.TabIndex = 627;
            this.lblDetainDate.Text = "[???]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblDetainID.Location = new System.Drawing.Point(160, 34);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(28, 25);
            this.lblDetainID.TabIndex = 626;
            this.lblDetainID.Text = "--";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD.Properties.Resources.detianID;
            this.pictureBox6.Location = new System.Drawing.Point(130, 36);
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
            this.lblSecName.TabIndex = 624;
            this.lblSecName.Text = "Detain ID ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(14, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 622;
            this.label8.Text = "Detain Date";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD.Properties.Resources.Date;
            this.pictureBox3.Location = new System.Drawing.Point(130, 70);
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
            this.label10.Location = new System.Drawing.Point(365, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 618;
            this.label10.Text = "Created By";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(485, 70);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 621;
            this.pictureBox7.TabStop = false;
            // 
            // LinkShowLicenseHistory
            // 
            this.LinkShowLicenseHistory.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.LinkShowLicenseHistory.AutoSize = true;
            this.LinkShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LinkShowLicenseHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkShowLicenseHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.LinkShowLicenseHistory.Location = new System.Drawing.Point(20, 693);
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
            this.LinkShowRenwLicenseInfo.Location = new System.Drawing.Point(210, 693);
            this.LinkShowRenwLicenseInfo.Name = "LinkShowRenwLicenseInfo";
            this.LinkShowRenwLicenseInfo.Size = new System.Drawing.Size(222, 23);
            this.LinkShowRenwLicenseInfo.TabIndex = 4;
            this.LinkShowRenwLicenseInfo.TabStop = true;
            this.LinkShowRenwLicenseInfo.Text = "Show Detained License Info";
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
            this.btnSave.Location = new System.Drawing.Point(545, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Detain";
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
            this.btnClose.Location = new System.Drawing.Point(705, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(854, 745);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlInfoBorder);
            this.Controls.Add(this.LinkShowRenwLicenseInfo);
            this.Controls.Add(this.ucDriverLicenseInfoFilter1);
            this.Controls.Add(this.LinkShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Government License Enforcement Center";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            this.pnlInfoBorder.ResumeLayout(false);
            this.grDetainApplicationInfo.ResumeLayout(false);
            this.grDetainApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFineFees)).EndInit();
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
        private System.Windows.Forms.Panel pnlInfoBorder;
        private System.Windows.Forms.GroupBox grDetainApplicationInfo;
        private System.Windows.Forms.NumericUpDown numFineFees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel LinkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel LinkShowRenwLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
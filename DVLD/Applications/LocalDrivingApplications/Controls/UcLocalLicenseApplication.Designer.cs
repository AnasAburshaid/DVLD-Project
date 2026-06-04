using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class UcLocalLicenseApplication
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.pnlPersonHeaderBorder = new System.Windows.Forms.Panel();
            this.pnlPersonHeader = new System.Windows.Forms.Panel();
            this.pnlAvatarWrap = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPersonHeaderTitle = new System.Windows.Forms.Label();
            this.lblPersonHeaderSub = new System.Windows.Forms.Label();
            this.usPersonCardFilter1 = new DVLD.UsPersonCardFilter();
            this.pnlTab1Footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.pnlSectionDivider = new System.Windows.Forms.Panel();
            this.pnlCard1Border = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.pnlIcon1 = new System.Windows.Forms.Panel();
            this.lblIcon1 = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblLocalAppID = new System.Windows.Forms.Label();
            this.pnlCard2Border = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlIcon2 = new System.Windows.Forms.Panel();
            this.lblIcon2 = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.pnlCard3Border = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.pnlIcon3 = new System.Windows.Forms.Panel();
            this.lblIcon3 = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.pnlCard4Border = new System.Windows.Forms.Panel();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.pnlIcon4 = new System.Windows.Forms.Panel();
            this.lblIcon4 = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pnlLicenseBorder = new System.Windows.Forms.Panel();
            this.pnlLicense = new System.Windows.Forms.Panel();
            this.pnlLicenseIcon = new System.Windows.Forms.Panel();
            this.lblLicenseIcon = new System.Windows.Forms.Label();
            this.lblLicenseTitle = new System.Windows.Forms.Label();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.pnlTab2Footer = new System.Windows.Forms.Panel();
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.pnlPersonHeaderBorder.SuspendLayout();
            this.pnlPersonHeader.SuspendLayout();
            this.pnlAvatarWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTab1Footer.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.pnlCard1Border.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlIcon1.SuspendLayout();
            this.pnlCard2Border.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlIcon2.SuspendLayout();
            this.pnlCard3Border.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlIcon3.SuspendLayout();
            this.pnlCard4Border.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlIcon4.SuspendLayout();
            this.pnlLicenseBorder.SuspendLayout();
            this.pnlLicense.SuspendLayout();
            this.pnlLicenseIcon.SuspendLayout();
            this.pnlTab2Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonalInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tpPersonalInfo.Controls.Add(this.pnlPersonHeaderBorder);
            this.tpPersonalInfo.Controls.Add(this.usPersonCardFilter1);
            this.tpPersonalInfo.Controls.Add(this.pnlTab1Footer);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 32);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Size = new System.Drawing.Size(861, 517);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "  Personal Info";
            // 
            // pnlPersonHeaderBorder
            // 
            this.pnlPersonHeaderBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.pnlPersonHeaderBorder.Controls.Add(this.pnlPersonHeader);
            this.pnlPersonHeaderBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonHeaderBorder.Name = "pnlPersonHeaderBorder";
            this.pnlPersonHeaderBorder.Size = new System.Drawing.Size(861, 72);
            this.pnlPersonHeaderBorder.TabIndex = 1;
            // 
            // pnlPersonHeader
            // 
            this.pnlPersonHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlPersonHeader.Controls.Add(this.pnlAvatarWrap);
            this.pnlPersonHeader.Controls.Add(this.lblPersonHeaderTitle);
            this.pnlPersonHeader.Controls.Add(this.lblPersonHeaderSub);
            this.pnlPersonHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonHeader.Name = "pnlPersonHeader";
            this.pnlPersonHeader.Size = new System.Drawing.Size(861, 71);
            this.pnlPersonHeader.TabIndex = 0;
            // 
            // pnlAvatarWrap
            // 
            this.pnlAvatarWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.pnlAvatarWrap.Controls.Add(this.pictureBox2);
            this.pnlAvatarWrap.Location = new System.Drawing.Point(20, 14);
            this.pnlAvatarWrap.Name = "pnlAvatarWrap";
            this.pnlAvatarWrap.Size = new System.Drawing.Size(40, 44);
            this.pnlAvatarWrap.TabIndex = 201;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Username2;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblPersonHeaderTitle
            // 
            this.lblPersonHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblPersonHeaderTitle.Location = new System.Drawing.Point(66, 16);
            this.lblPersonHeaderTitle.Name = "lblPersonHeaderTitle";
            this.lblPersonHeaderTitle.Size = new System.Drawing.Size(500, 22);
            this.lblPersonHeaderTitle.TabIndex = 1;
            this.lblPersonHeaderTitle.Text = "Person Card Search";
            // 
            // lblPersonHeaderSub
            // 
            this.lblPersonHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPersonHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblPersonHeaderSub.Location = new System.Drawing.Point(69, 38);
            this.lblPersonHeaderSub.Name = "lblPersonHeaderSub";
            this.lblPersonHeaderSub.Size = new System.Drawing.Size(500, 20);
            this.lblPersonHeaderSub.TabIndex = 2;
            this.lblPersonHeaderSub.Text = "Search by national ID or profile number";
            // 
            // usPersonCardFilter1
            // 
            this.usPersonCardFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.usPersonCardFilter1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usPersonCardFilter1.Location = new System.Drawing.Point(0, 67);
            this.usPersonCardFilter1.Margin = new System.Windows.Forms.Padding(0);
            this.usPersonCardFilter1.Name = "usPersonCardFilter1";
            this.usPersonCardFilter1.Size = new System.Drawing.Size(861, 412);
            this.usPersonCardFilter1.TabIndex = 0;
            this.usPersonCardFilter1.OnPersonSelected += new System.Action<int>(this.usPersonCardFilter1_OnPersonSelected);
            // 
            // pnlTab1Footer
            // 
            this.pnlTab1Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnlTab1Footer.Controls.Add(this.button1);
            this.pnlTab1Footer.Controls.Add(this.btnNext);
            this.pnlTab1Footer.Location = new System.Drawing.Point(0, 473);
            this.pnlTab1Footer.Name = "pnlTab1Footer";
            this.pnlTab1Footer.Size = new System.Drawing.Size(861, 42);
            this.pnlTab1Footer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.button1.Location = new System.Drawing.Point(562, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(720, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next  ▶";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tpApplicationInfo.Controls.Add(this.lblSectionTitle);
            this.tpApplicationInfo.Controls.Add(this.pnlSectionDivider);
            this.tpApplicationInfo.Controls.Add(this.pnlCard1Border);
            this.tpApplicationInfo.Controls.Add(this.pnlCard2Border);
            this.tpApplicationInfo.Controls.Add(this.pnlCard3Border);
            this.tpApplicationInfo.Controls.Add(this.pnlCard4Border);
            this.tpApplicationInfo.Controls.Add(this.pnlLicenseBorder);
            this.tpApplicationInfo.Controls.Add(this.pnlTab2Footer);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 32);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Size = new System.Drawing.Size(861, 517);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "  Application Info";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(24, 22);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(200, 18);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "APPLICATION DETAILS";
            // 
            // pnlSectionDivider
            // 
            this.pnlSectionDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlSectionDivider.Location = new System.Drawing.Point(24, 44);
            this.pnlSectionDivider.Name = "pnlSectionDivider";
            this.pnlSectionDivider.Size = new System.Drawing.Size(813, 1);
            this.pnlSectionDivider.TabIndex = 1;
            // 
            // pnlCard1Border
            // 
            this.pnlCard1Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlCard1Border.Controls.Add(this.pnlCard1);
            this.pnlCard1Border.Location = new System.Drawing.Point(24, 58);
            this.pnlCard1Border.Name = "pnlCard1Border";
            this.pnlCard1Border.Size = new System.Drawing.Size(400, 82);
            this.pnlCard1Border.TabIndex = 2;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.pnlIcon1);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblLocalAppID);
            this.pnlCard1.Location = new System.Drawing.Point(1, 1);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(398, 80);
            this.pnlCard1.TabIndex = 0;
            // 
            // pnlIcon1
            // 
            this.pnlIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.pnlIcon1.Controls.Add(this.lblIcon1);
            this.pnlIcon1.Location = new System.Drawing.Point(14, 21);
            this.pnlIcon1.Name = "pnlIcon1";
            this.pnlIcon1.Size = new System.Drawing.Size(38, 38);
            this.pnlIcon1.TabIndex = 0;
            // 
            // lblIcon1
            // 
            this.lblIcon1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblIcon1.Location = new System.Drawing.Point(0, 0);
            this.lblIcon1.Name = "lblIcon1";
            this.lblIcon1.Size = new System.Drawing.Size(38, 38);
            this.lblIcon1.TabIndex = 0;
            this.lblIcon1.Text = "#";
            this.lblIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblCard1Title.Location = new System.Drawing.Point(66, 16);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(320, 16);
            this.lblCard1Title.TabIndex = 1;
            this.lblCard1Title.Text = "L.L. APPLICATION ID";
            // 
            // lblLocalAppID
            // 
            this.lblLocalAppID.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.lblLocalAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblLocalAppID.Location = new System.Drawing.Point(66, 36);
            this.lblLocalAppID.Name = "lblLocalAppID";
            this.lblLocalAppID.Size = new System.Drawing.Size(320, 28);
            this.lblLocalAppID.TabIndex = 2;
            this.lblLocalAppID.Text = "--";
            // 
            // pnlCard2Border
            // 
            this.pnlCard2Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlCard2Border.Controls.Add(this.pnlCard2);
            this.pnlCard2Border.Location = new System.Drawing.Point(437, 58);
            this.pnlCard2Border.Name = "pnlCard2Border";
            this.pnlCard2Border.Size = new System.Drawing.Size(400, 82);
            this.pnlCard2Border.TabIndex = 3;
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.pnlIcon2);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblAppDate);
            this.pnlCard2.Location = new System.Drawing.Point(1, 1);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(398, 80);
            this.pnlCard2.TabIndex = 0;
            // 
            // pnlIcon2
            // 
            this.pnlIcon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.pnlIcon2.Controls.Add(this.lblIcon2);
            this.pnlIcon2.Location = new System.Drawing.Point(14, 21);
            this.pnlIcon2.Name = "pnlIcon2";
            this.pnlIcon2.Size = new System.Drawing.Size(38, 38);
            this.pnlIcon2.TabIndex = 0;
            // 
            // lblIcon2
            // 
            this.lblIcon2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblIcon2.Location = new System.Drawing.Point(0, 0);
            this.lblIcon2.Name = "lblIcon2";
            this.lblIcon2.Size = new System.Drawing.Size(38, 38);
            this.lblIcon2.TabIndex = 0;
            this.lblIcon2.Text = "D";
            this.lblIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblCard2Title.Location = new System.Drawing.Point(66, 16);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(320, 16);
            this.lblCard2Title.TabIndex = 1;
            this.lblCard2Title.Text = "APPLICATION DATE";
            // 
            // lblAppDate
            // 
            this.lblAppDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblAppDate.Location = new System.Drawing.Point(66, 36);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(320, 28);
            this.lblAppDate.TabIndex = 2;
            this.lblAppDate.Text = "[???]";
            // 
            // pnlCard3Border
            // 
            this.pnlCard3Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlCard3Border.Controls.Add(this.pnlCard3);
            this.pnlCard3Border.Location = new System.Drawing.Point(24, 153);
            this.pnlCard3Border.Name = "pnlCard3Border";
            this.pnlCard3Border.Size = new System.Drawing.Size(400, 82);
            this.pnlCard3Border.TabIndex = 4;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.pnlIcon3);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblAppFees);
            this.pnlCard3.Location = new System.Drawing.Point(1, 1);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(398, 80);
            this.pnlCard3.TabIndex = 0;
            // 
            // pnlIcon3
            // 
            this.pnlIcon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.pnlIcon3.Controls.Add(this.lblIcon3);
            this.pnlIcon3.Location = new System.Drawing.Point(14, 21);
            this.pnlIcon3.Name = "pnlIcon3";
            this.pnlIcon3.Size = new System.Drawing.Size(38, 38);
            this.pnlIcon3.TabIndex = 0;
            // 
            // lblIcon3
            // 
            this.lblIcon3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblIcon3.Location = new System.Drawing.Point(0, 0);
            this.lblIcon3.Name = "lblIcon3";
            this.lblIcon3.Size = new System.Drawing.Size(38, 38);
            this.lblIcon3.TabIndex = 0;
            this.lblIcon3.Text = "$";
            this.lblIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblCard3Title.Location = new System.Drawing.Point(66, 16);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(320, 16);
            this.lblCard3Title.TabIndex = 1;
            this.lblCard3Title.Text = "APPLICATION FEES";
            // 
            // lblAppFees
            // 
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblAppFees.Location = new System.Drawing.Point(66, 36);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(320, 28);
            this.lblAppFees.TabIndex = 2;
            this.lblAppFees.Text = "[???]";
            // 
            // pnlCard4Border
            // 
            this.pnlCard4Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlCard4Border.Controls.Add(this.pnlCard4);
            this.pnlCard4Border.Location = new System.Drawing.Point(437, 153);
            this.pnlCard4Border.Name = "pnlCard4Border";
            this.pnlCard4Border.Size = new System.Drawing.Size(400, 82);
            this.pnlCard4Border.TabIndex = 5;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Controls.Add(this.pnlIcon4);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblCreatedBy);
            this.pnlCard4.Location = new System.Drawing.Point(1, 1);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(398, 80);
            this.pnlCard4.TabIndex = 0;
            // 
            // pnlIcon4
            // 
            this.pnlIcon4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.pnlIcon4.Controls.Add(this.lblIcon4);
            this.pnlIcon4.Location = new System.Drawing.Point(14, 21);
            this.pnlIcon4.Name = "pnlIcon4";
            this.pnlIcon4.Size = new System.Drawing.Size(38, 38);
            this.pnlIcon4.TabIndex = 0;
            // 
            // lblIcon4
            // 
            this.lblIcon4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblIcon4.Location = new System.Drawing.Point(0, 0);
            this.lblIcon4.Name = "lblIcon4";
            this.lblIcon4.Size = new System.Drawing.Size(38, 38);
            this.lblIcon4.TabIndex = 0;
            this.lblIcon4.Text = "@";
            this.lblIcon4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblCard4Title.Location = new System.Drawing.Point(66, 16);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(320, 16);
            this.lblCard4Title.TabIndex = 1;
            this.lblCard4Title.Text = "CREATED BY";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(66, 36);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(320, 28);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "[???]";
            // 
            // pnlLicenseBorder
            // 
            this.pnlLicenseBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlLicenseBorder.Controls.Add(this.pnlLicense);
            this.pnlLicenseBorder.Location = new System.Drawing.Point(24, 253);
            this.pnlLicenseBorder.Name = "pnlLicenseBorder";
            this.pnlLicenseBorder.Size = new System.Drawing.Size(813, 78);
            this.pnlLicenseBorder.TabIndex = 6;
            // 
            // pnlLicense
            // 
            this.pnlLicense.BackColor = System.Drawing.Color.White;
            this.pnlLicense.Controls.Add(this.pnlLicenseIcon);
            this.pnlLicense.Controls.Add(this.lblLicenseTitle);
            this.pnlLicense.Controls.Add(this.cmbLicenseClass);
            this.pnlLicense.Location = new System.Drawing.Point(1, 1);
            this.pnlLicense.Name = "pnlLicense";
            this.pnlLicense.Size = new System.Drawing.Size(811, 77);
            this.pnlLicense.TabIndex = 0;
            // 
            // pnlLicenseIcon
            // 
            this.pnlLicenseIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlLicenseIcon.Controls.Add(this.lblLicenseIcon);
            this.pnlLicenseIcon.Location = new System.Drawing.Point(14, 19);
            this.pnlLicenseIcon.Name = "pnlLicenseIcon";
            this.pnlLicenseIcon.Size = new System.Drawing.Size(38, 38);
            this.pnlLicenseIcon.TabIndex = 0;
            // 
            // lblLicenseIcon
            // 
            this.lblLicenseIcon.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLicenseIcon.ForeColor = System.Drawing.Color.White;
            this.lblLicenseIcon.Location = new System.Drawing.Point(0, 0);
            this.lblLicenseIcon.Name = "lblLicenseIcon";
            this.lblLicenseIcon.Size = new System.Drawing.Size(38, 38);
            this.lblLicenseIcon.TabIndex = 0;
            this.lblLicenseIcon.Text = "L";
            this.lblLicenseIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicenseTitle
            // 
            this.lblLicenseTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLicenseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.lblLicenseTitle.Location = new System.Drawing.Point(66, 17);
            this.lblLicenseTitle.Name = "lblLicenseTitle";
            this.lblLicenseTitle.Size = new System.Drawing.Size(200, 16);
            this.lblLicenseTitle.TabIndex = 1;
            this.lblLicenseTitle.Text = "LICENSE CLASS";
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.cmbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Location = new System.Drawing.Point(66, 36);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(300, 31);
            this.cmbLicenseClass.TabIndex = 2;
            // 
            // pnlTab2Footer
            // 
            this.pnlTab2Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnlTab2Footer.Controls.Add(this.pnlFooterLine);
            this.pnlTab2Footer.Controls.Add(this.btnSave);
            this.pnlTab2Footer.Controls.Add(this.btnClose);
            this.pnlTab2Footer.Location = new System.Drawing.Point(0, 468);
            this.pnlTab2Footer.Name = "pnlTab2Footer";
            this.pnlTab2Footer.Size = new System.Drawing.Size(861, 49);
            this.pnlTab2Footer.TabIndex = 7;
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(232)))));
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(861, 1);
            this.pnlFooterLine.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(48)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(606, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(736, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UcLocalLicenseApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "UcLocalLicenseApplication";
            this.Size = new System.Drawing.Size(869, 553);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.pnlPersonHeaderBorder.ResumeLayout(false);
            this.pnlPersonHeader.ResumeLayout(false);
            this.pnlAvatarWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTab1Footer.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.pnlCard1Border.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlIcon1.ResumeLayout(false);
            this.pnlCard2Border.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlIcon2.ResumeLayout(false);
            this.pnlCard3Border.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlIcon3.ResumeLayout(false);
            this.pnlCard4Border.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlIcon4.ResumeLayout(false);
            this.pnlLicenseBorder.ResumeLayout(false);
            this.pnlLicense.ResumeLayout(false);
            this.pnlLicenseIcon.ResumeLayout(false);
            this.pnlTab2Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Panel pnlPersonHeaderBorder;
        private System.Windows.Forms.Panel pnlPersonHeader;
        private System.Windows.Forms.Label lblPersonHeaderTitle;
        private System.Windows.Forms.Label lblPersonHeaderSub;
        private DVLD.UsPersonCardFilter usPersonCardFilter1;
        private System.Windows.Forms.Panel pnlTab1Footer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Panel pnlSectionDivider;
        private System.Windows.Forms.Panel pnlCard1Border;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlIcon1;
        private System.Windows.Forms.Label lblIcon1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblLocalAppID;
        private System.Windows.Forms.Panel pnlCard2Border;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlIcon2;
        private System.Windows.Forms.Label lblIcon2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Panel pnlCard3Border;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlIcon3;
        private System.Windows.Forms.Label lblIcon3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Panel pnlCard4Border;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Panel pnlIcon4;
        private System.Windows.Forms.Label lblIcon4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Panel pnlLicenseBorder;
        private System.Windows.Forms.Panel pnlLicense;
        private System.Windows.Forms.Panel pnlLicenseIcon;
        private System.Windows.Forms.Label lblLicenseIcon;
        private System.Windows.Forms.Label lblLicenseTitle;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
        private System.Windows.Forms.Panel pnlTab2Footer;
        private System.Windows.Forms.Panel pnlFooterLine;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Panel pnlAvatarWrap;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
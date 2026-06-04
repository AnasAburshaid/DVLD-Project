using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmShowPersonLicensesHistory
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
            this.pnlHeaderBanner = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucShowLicenseHistory1 = new DVLD.UcShowLicenseHistory();
            this.usPersonInformationCard1 = new DVLD.UsPersonInformationCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeaderBanner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderBanner
            // 
            this.pnlHeaderBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlHeaderBanner.Controls.Add(this.lblFormTitle);
            this.pnlHeaderBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBanner.Name = "pnlHeaderBanner";
            this.pnlHeaderBanner.Size = new System.Drawing.Size(905, 65);
            this.pnlHeaderBanner.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(905, 65);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Person License History Ledger";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ucShowLicenseHistory1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " License History Records ";
            // 
            // ucShowLicenseHistory1
            // 
            this.ucShowLicenseHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucShowLicenseHistory1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucShowLicenseHistory1.Location = new System.Drawing.Point(1, 23);
            this.ucShowLicenseHistory1.Name = "ucShowLicenseHistory1";
            this.ucShowLicenseHistory1.Size = new System.Drawing.Size(878, 311);
            this.ucShowLicenseHistory1.TabIndex = 0;
            // 
            // usPersonInformationCard1
            // 
            this.usPersonInformationCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.usPersonInformationCard1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.usPersonInformationCard1.Location = new System.Drawing.Point(12, 75);
            this.usPersonInformationCard1.Name = "usPersonInformationCard1";
            this.usPersonInformationCard1.Size = new System.Drawing.Size(880, 314);
            this.usPersonInformationCard1.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(773, 731);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmShowPersonLicensesHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(905, 776);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usPersonInformationCard1);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPersonLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person License History Access Portal";
            this.Load += new System.EventHandler(this.frmShowPersonLicensesHistory_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label lblFormTitle;
        private UsPersonInformationCard usPersonInformationCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UcShowLicenseHistory ucShowLicenseHistory1;
        private System.Windows.Forms.Button btnClose;
    }
}
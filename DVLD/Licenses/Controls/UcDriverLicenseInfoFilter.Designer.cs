using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class UcDriverLicenseInfoFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucDriverLicenseInfo1 = new DVLD.UcDriverLicenseInfo();
            this.pnlSearchBanner = new System.Windows.Forms.Panel();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlInputWrapper = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.pnlSearchBanner.SuspendLayout();
            this.pnlInputWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucDriverLicenseInfo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(0, 85);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(850, 398);
            this.ucDriverLicenseInfo1.TabIndex = 1;
            // 
            // pnlSearchBanner
            // 
            this.pnlSearchBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlSearchBanner.Controls.Add(this.lblSearchTitle);
            this.pnlSearchBanner.Controls.Add(this.btnSearch);
            this.pnlSearchBanner.Controls.Add(this.pnlInputWrapper);
            this.pnlSearchBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchBanner.Name = "pnlSearchBanner";
            this.pnlSearchBanner.Size = new System.Drawing.Size(850, 75);
            this.pnlSearchBanner.TabIndex = 0;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.White;
            this.lblSearchTitle.Location = new System.Drawing.Point(18, 25);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(121, 25);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "LICENSE ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(525, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlInputWrapper
            // 
            this.pnlInputWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.pnlInputWrapper.Controls.Add(this.pictureBox1);
            this.pnlInputWrapper.Controls.Add(this.txtSearchFilter);
            this.pnlInputWrapper.Location = new System.Drawing.Point(150, 19);
            this.pnlInputWrapper.Name = "pnlInputWrapper";
            this.pnlInputWrapper.Size = new System.Drawing.Size(360, 36);
            this.pnlInputWrapper.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseID;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.txtSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.txtSearchFilter.Location = new System.Drawing.Point(40, 6);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(310, 25);
            this.txtSearchFilter.TabIndex = 0;
            // 
            // UcDriverLicenseInfoFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnlSearchBanner);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "UcDriverLicenseInfoFilter";
            this.Size = new System.Drawing.Size(850, 485);
            this.Load += new System.EventHandler(this.UcDriverLicenseInfoFilter_Load);
            this.pnlSearchBanner.ResumeLayout(false);
            this.pnlSearchBanner.PerformLayout();
            this.pnlInputWrapper.ResumeLayout(false);
            this.pnlInputWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcDriverLicenseInfo ucDriverLicenseInfo1;
        private System.Windows.Forms.Panel pnlSearchBanner;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Panel pnlInputWrapper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.Button btnSearch;
    }
}
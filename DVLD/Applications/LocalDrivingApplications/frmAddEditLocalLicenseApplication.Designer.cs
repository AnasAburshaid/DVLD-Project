using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmAddEditLocalLicenseApplication
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
            this.lblMode = new System.Windows.Forms.Label();
            this.ucLocalLicenseApplication1 = new DVLD.UcLocalLicenseApplication();
            this.pnlHeaderBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderBanner
            // 
            this.pnlHeaderBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.pnlHeaderBanner.Controls.Add(this.lblMode);
            this.pnlHeaderBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBanner.Name = "pnlHeaderBanner";
            this.pnlHeaderBanner.Size = new System.Drawing.Size(869, 65);
            this.pnlHeaderBanner.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(869, 65);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "New Local Driving License Application";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucLocalLicenseApplication1
            // 
            this.ucLocalLicenseApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucLocalLicenseApplication1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucLocalLicenseApplication1.Location = new System.Drawing.Point(0, 75);
            this.ucLocalLicenseApplication1.Name = "ucLocalLicenseApplication1";
            this.ucLocalLicenseApplication1.Size = new System.Drawing.Size(869, 553);
            this.ucLocalLicenseApplication1.TabIndex = 1;
            // 
            // frmAddEditLocalLicenseApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(869, 636);
            this.Controls.Add(this.ucLocalLicenseApplication1);
            this.Controls.Add(this.pnlHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditLocalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local License Application Workspace";
            this.Load += new System.EventHandler(this.frmAddEditLocalLicenseApplication_Load);
            this.pnlHeaderBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderBanner;
        private System.Windows.Forms.Label lblMode;
        private UcLocalLicenseApplication ucLocalLicenseApplication1;
    }
}
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class frmShowInternationalLicenseInfo
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
            this.ucInternationalLicenseCardInfo1 = new DVLD.UcInternationalLicenseCardInfo();
            this.pnlFooterActions = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFooterActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // ucInternationalLicenseCardInfo1
            // 
            this.ucInternationalLicenseCardInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ucInternationalLicenseCardInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInternationalLicenseCardInfo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucInternationalLicenseCardInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucInternationalLicenseCardInfo1.Name = "ucInternationalLicenseCardInfo1";
            this.ucInternationalLicenseCardInfo1.Size = new System.Drawing.Size(845, 395);
            this.ucInternationalLicenseCardInfo1.TabIndex = 0;
            // 
            // pnlFooterActions
            // 
            this.pnlFooterActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlFooterActions.Controls.Add(this.pictureBox10);
            this.pnlFooterActions.Controls.Add(this.btnClose);
            this.pnlFooterActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterActions.Location = new System.Drawing.Point(0, 341);
            this.pnlFooterActions.Name = "pnlFooterActions";
            this.pnlFooterActions.Size = new System.Drawing.Size(845, 65);
            this.pnlFooterActions.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::DVLD.Properties.Resources.Close;
            this.pictureBox10.Location = new System.Drawing.Point(714, 22);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(701, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowInternationalLicenseInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.pnlFooterActions);
            this.Controls.Add(this.ucInternationalLicenseCardInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "International Driver License Verification Registry";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load);
            this.pnlFooterActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcInternationalLicenseCardInfo ucInternationalLicenseCardInfo1;
        private System.Windows.Forms.Panel pnlFooterActions;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btnClose;
    }
}
using System;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    partial class UsPersonCardFilter
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
            this.GrFilterBox = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmpFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usPersonInformationCard1 = new DVLD.UsPersonInformationCard();
            this.GrFilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrFilterBox
            // 
            this.GrFilterBox.BackColor = System.Drawing.Color.White;
            this.GrFilterBox.Controls.Add(this.btnAddPerson);
            this.GrFilterBox.Controls.Add(this.btnSearch);
            this.GrFilterBox.Controls.Add(this.cmpFilter);
            this.GrFilterBox.Controls.Add(this.txtSearchFilter);
            this.GrFilterBox.Controls.Add(this.label1);
            this.GrFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrFilterBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.GrFilterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(155)))), ((int)(((byte)(175)))));
            this.GrFilterBox.Location = new System.Drawing.Point(15, 10);
            this.GrFilterBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrFilterBox.Name = "GrFilterBox";
            this.GrFilterBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrFilterBox.Size = new System.Drawing.Size(835, 95);
            this.GrFilterBox.TabIndex = 1;
            this.GrFilterBox.TabStop = false;
            this.GrFilterBox.Text = " Search Filters ";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLD.Properties.Resources.add_user;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Location = new System.Drawing.Point(590, 32);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(38, 38);
            this.btnAddPerson.TabIndex = 10;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.search_profile;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(541, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 38);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmpFilter
            // 
            this.cmpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.cmpFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmpFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.cmpFilter.FormattingEnabled = true;
            this.cmpFilter.Items.AddRange(new object[] {
            "National Number",
            "Person ID"});
            this.cmpFilter.Location = new System.Drawing.Point(110, 35);
            this.cmpFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmpFilter.Name = "cmpFilter";
            this.cmpFilter.Size = new System.Drawing.Size(180, 31);
            this.cmpFilter.TabIndex = 8;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.txtSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.txtSearchFilter.Location = new System.Drawing.Point(305, 35);
            this.txtSearchFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(220, 32);
            this.txtSearchFilter.TabIndex = 7;
            this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // usPersonInformationCard1
            // 
            this.usPersonInformationCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.usPersonInformationCard1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usPersonInformationCard1.Location = new System.Drawing.Point(0, 115);
            this.usPersonInformationCard1.Name = "usPersonInformationCard1";
            this.usPersonInformationCard1.Size = new System.Drawing.Size(869, 362);
            this.usPersonInformationCard1.TabIndex = 2;
            // 
            // UsPersonCardFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.usPersonInformationCard1);
            this.Controls.Add(this.GrFilterBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsPersonCardFilter";
            this.Size = new System.Drawing.Size(869, 485);
            this.Load += new System.EventHandler(this.UsPersonCardFilter_Load);
            this.GrFilterBox.ResumeLayout(false);
            this.GrFilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.ComboBox cmpFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private UsPersonInformationCard usPersonInformationCard1;
    }
}
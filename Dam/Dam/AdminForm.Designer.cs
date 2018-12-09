using System;

namespace Dam
{
    partial class AdminForm
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
            this.LTitle = new System.Windows.Forms.Label();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LBAssetViewer = new System.Windows.Forms.ListBox();
            this.GBFilters = new System.Windows.Forms.GroupBox();
            this.deleteAF = new System.Windows.Forms.Button();
            this.addAF = new System.Windows.Forms.Button();
            this.sortByBox = new System.Windows.Forms.ComboBox();
            this.filtersListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.LKeyword = new System.Windows.Forms.Label();
            this.GBFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(88, 15);
            this.LTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(408, 29);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Digital Asset Management System";
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Location = new System.Drawing.Point(8, 10);
            this.btnEditLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(85, 46);
            this.btnEditLogin.TabIndex = 1;
            this.btnEditLogin.Text = "Edit Logins";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(491, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LBAssetViewer
            // 
            this.LBAssetViewer.FormattingEnabled = true;
            this.LBAssetViewer.Location = new System.Drawing.Point(218, 75);
            this.LBAssetViewer.Margin = new System.Windows.Forms.Padding(2);
            this.LBAssetViewer.Name = "LBAssetViewer";
            this.LBAssetViewer.Size = new System.Drawing.Size(359, 238);
            this.LBAssetViewer.TabIndex = 3;
            // 
            // GBFilters
            // 
            this.GBFilters.Controls.Add(this.deleteAF);
            this.GBFilters.Controls.Add(this.addAF);
            this.GBFilters.Controls.Add(this.sortByBox);
            this.GBFilters.Controls.Add(this.filtersListBox);
            this.GBFilters.Controls.Add(this.label1);
            this.GBFilters.Controls.Add(this.btnSearch);
            this.GBFilters.Location = new System.Drawing.Point(9, 116);
            this.GBFilters.Margin = new System.Windows.Forms.Padding(2);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Padding = new System.Windows.Forms.Padding(2);
            this.GBFilters.Size = new System.Drawing.Size(191, 240);
            this.GBFilters.TabIndex = 4;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filters";
            // 
            // deleteAF
            // 
            this.deleteAF.Location = new System.Drawing.Point(107, 108);
            this.deleteAF.Name = "deleteAF";
            this.deleteAF.Size = new System.Drawing.Size(75, 23);
            this.deleteAF.TabIndex = 26;
            this.deleteAF.Text = "Delete";
            this.deleteAF.UseVisualStyleBackColor = true;
            this.deleteAF.Click += new System.EventHandler(this.deleteAF_Click);
            // 
            // addAF
            // 
            this.addAF.Location = new System.Drawing.Point(6, 108);
            this.addAF.Name = "addAF";
            this.addAF.Size = new System.Drawing.Size(75, 23);
            this.addAF.TabIndex = 25;
            this.addAF.Text = "Add";
            this.addAF.UseVisualStyleBackColor = true;
            this.addAF.Click += new System.EventHandler(this.addAF_Click);
            // 
            // sortByBox
            // 
            this.sortByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByBox.FormattingEnabled = true;
            this.sortByBox.Items.AddRange(new object[] {
            "A-Z (First Name)",
            "A-Z (Last Name)",
            "Z-A (First Name)",
            "Z-A (Last Name)",
            "ID"});
            this.sortByBox.Location = new System.Drawing.Point(5, 171);
            this.sortByBox.Name = "sortByBox";
            this.sortByBox.Size = new System.Drawing.Size(177, 21);
            this.sortByBox.TabIndex = 24;
            this.sortByBox.SelectedIndexChanged += new System.EventHandler(this.sortByBox_SelectedIndexChanged);
            // 
            // filtersListBox
            // 
            this.filtersListBox.FormattingEnabled = true;
            this.filtersListBox.Items.AddRange(new object[] {
            "Intake Form",
            "Birth Certificate",
            "Medical Form"});
            this.filtersListBox.Location = new System.Drawing.Point(5, 18);
            this.filtersListBox.Name = "filtersListBox";
            this.filtersListBox.Size = new System.Drawing.Size(181, 64);
            this.filtersListBox.TabIndex = 23;
            this.filtersListBox.SelectedIndexChanged += new System.EventHandler(this.filtersListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "SortBy";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 198);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 33);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(218, 318);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(86, 39);
            this.btnAddAsset.TabIndex = 5;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Location = new System.Drawing.Point(309, 318);
            this.btnDeleteAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(86, 39);
            this.btnDeleteAsset.TabIndex = 6;
            this.btnDeleteAsset.Text = "Delete Asset";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(490, 317);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(86, 39);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.Text = "Log";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(400, 318);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(86, 39);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(64, 75);
            this.tbKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(138, 19);
            this.tbKeyword.TabIndex = 17;
            // 
            // LKeyword
            // 
            this.LKeyword.AutoSize = true;
            this.LKeyword.Location = new System.Drawing.Point(7, 75);
            this.LKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LKeyword.Name = "LKeyword";
            this.LKeyword.Size = new System.Drawing.Size(54, 13);
            this.LKeyword.TabIndex = 16;
            this.LKeyword.Text = "Keyword :";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.LKeyword);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnDeleteAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.GBFilters);
            this.Controls.Add(this.LBAssetViewer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditLogin);
            this.Controls.Add(this.LTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.GBFilters.ResumeLayout(false);
            this.GBFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox LBAssetViewer;
        private System.Windows.Forms.GroupBox GBFilters;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.Button btnDeleteAsset;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label LKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox filtersListBox;
        private System.Windows.Forms.ComboBox sortByBox;
        private System.Windows.Forms.Button deleteAF;
        private System.Windows.Forms.Button addAF;
    }
}
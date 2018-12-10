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
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnRemoveDocument = new System.Windows.Forms.Button();
            this.GBFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(135, 18);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(496, 36);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Digital Asset Management System";
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Location = new System.Drawing.Point(12, 12);
            this.btnEditLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(113, 57);
            this.btnEditLogin.TabIndex = 1;
            this.btnEditLogin.Text = "Edit Logins";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(684, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 57);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LBAssetViewer
            // 
            this.LBAssetViewer.FormattingEnabled = true;
            this.LBAssetViewer.ItemHeight = 16;
            this.LBAssetViewer.Location = new System.Drawing.Point(319, 94);
            this.LBAssetViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBAssetViewer.Name = "LBAssetViewer";
            this.LBAssetViewer.Size = new System.Drawing.Size(477, 292);
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
            this.GBFilters.Location = new System.Drawing.Point(14, 186);
            this.GBFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFilters.Size = new System.Drawing.Size(255, 255);
            this.GBFilters.TabIndex = 4;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filters";
            // 
            // deleteAF
            // 
            this.deleteAF.Location = new System.Drawing.Point(142, 113);
            this.deleteAF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteAF.Name = "deleteAF";
            this.deleteAF.Size = new System.Drawing.Size(100, 28);
            this.deleteAF.TabIndex = 26;
            this.deleteAF.Text = "Delete";
            this.deleteAF.UseVisualStyleBackColor = true;
            this.deleteAF.Click += new System.EventHandler(this.deleteAF_Click);
            // 
            // addAF
            // 
            this.addAF.Location = new System.Drawing.Point(7, 113);
            this.addAF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAF.Name = "addAF";
            this.addAF.Size = new System.Drawing.Size(100, 28);
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
            this.sortByBox.Location = new System.Drawing.Point(9, 168);
            this.sortByBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortByBox.Name = "sortByBox";
            this.sortByBox.Size = new System.Drawing.Size(235, 24);
            this.sortByBox.TabIndex = 24;
            // 
            // filtersListBox
            // 
            this.filtersListBox.FormattingEnabled = true;
            this.filtersListBox.Items.AddRange(new object[] {
            "Intake Form",
            "Birth Certificate",
            "Medical Form"});
            this.filtersListBox.Location = new System.Drawing.Point(7, 22);
            this.filtersListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtersListBox.Name = "filtersListBox";
            this.filtersListBox.Size = new System.Drawing.Size(240, 72);
            this.filtersListBox.TabIndex = 23;
            this.filtersListBox.SelectedIndexChanged += new System.EventHandler(this.filtersListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sort By:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 202);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(237, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(319, 393);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(115, 48);
            this.btnAddAsset.TabIndex = 5;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Location = new System.Drawing.Point(440, 393);
            this.btnDeleteAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(115, 48);
            this.btnDeleteAsset.TabIndex = 6;
            this.btnDeleteAsset.Text = "Delete Asset";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(681, 393);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(115, 48);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.Text = "Log";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(561, 393);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(115, 48);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(85, 92);
            this.tbKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(183, 22);
            this.tbKeyword.TabIndex = 17;
            // 
            // LKeyword
            // 
            this.LKeyword.AutoSize = true;
            this.LKeyword.Location = new System.Drawing.Point(11, 95);
            this.LKeyword.Name = "LKeyword";
            this.LKeyword.Size = new System.Drawing.Size(70, 17);
            this.LKeyword.TabIndex = 16;
            this.LKeyword.Text = "Keyword :";
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(24, 135);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(82, 46);
            this.btnAddDocument.TabIndex = 18;
            this.btnAddDocument.Text = "Add Document";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnRemoveDocument
            // 
            this.btnRemoveDocument.Location = new System.Drawing.Point(187, 135);
            this.btnRemoveDocument.Name = "btnRemoveDocument";
            this.btnRemoveDocument.Size = new System.Drawing.Size(82, 46);
            this.btnRemoveDocument.TabIndex = 19;
            this.btnRemoveDocument.Text = "Remove Document";
            this.btnRemoveDocument.UseVisualStyleBackColor = true;
            this.btnRemoveDocument.Click += new System.EventHandler(this.btnRemoveDocument_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btnRemoveDocument);
            this.Controls.Add(this.btnAddDocument);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox sortByBox;
        private System.Windows.Forms.Button deleteAF;
        private System.Windows.Forms.Button addAF;
        public System.Windows.Forms.CheckedListBox filtersListBox;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnRemoveDocument;
    }
}
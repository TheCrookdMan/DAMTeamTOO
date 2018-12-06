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
            this.LTitle.Location = new System.Drawing.Point(117, 18);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(496, 36);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Digital Asset Management System";
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Location = new System.Drawing.Point(11, 12);
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
            this.btnLogout.Location = new System.Drawing.Point(655, 12);
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
            this.LBAssetViewer.Location = new System.Drawing.Point(291, 92);
            this.LBAssetViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBAssetViewer.Name = "LBAssetViewer";
            this.LBAssetViewer.Size = new System.Drawing.Size(477, 292);
            this.LBAssetViewer.TabIndex = 3;
            // 
            // GBFilters
            // 
            this.GBFilters.Controls.Add(this.sortByBox);
            this.GBFilters.Controls.Add(this.filtersListBox);
            this.GBFilters.Controls.Add(this.label1);
            this.GBFilters.Controls.Add(this.btnSearch);
            this.GBFilters.Location = new System.Drawing.Point(12, 143);
            this.GBFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBFilters.Size = new System.Drawing.Size(255, 295);
            this.GBFilters.TabIndex = 4;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filters";
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
            this.sortByBox.Location = new System.Drawing.Point(7, 155);
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
            this.filtersListBox.Size = new System.Drawing.Size(240, 89);
            this.filtersListBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "SortBy";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 244);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(237, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(291, 391);
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
            this.btnDeleteAsset.Location = new System.Drawing.Point(412, 391);
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
            this.btnOptions.Location = new System.Drawing.Point(653, 390);
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
            this.btnBackup.Location = new System.Drawing.Point(533, 391);
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
            this.LKeyword.Location = new System.Drawing.Point(9, 92);
            this.LKeyword.Name = "LKeyword";
            this.LKeyword.Size = new System.Drawing.Size(70, 17);
            this.LKeyword.TabIndex = 16;
            this.LKeyword.Text = "Keyword :";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            throw new Exception("OwO what is this? A error message? Hmmmmmmmm....");
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
    }
}
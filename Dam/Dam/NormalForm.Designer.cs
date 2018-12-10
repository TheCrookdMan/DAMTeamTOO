namespace Dam
{
    partial class NormalForm
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
            this.LBAssetViewer = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.LTitle = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.LKeyword = new System.Windows.Forms.Label();
            this.GBFilters = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GBFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBAssetViewer
            // 
            this.LBAssetViewer.FormattingEnabled = true;
            this.LBAssetViewer.Location = new System.Drawing.Point(240, 79);
            this.LBAssetViewer.Margin = new System.Windows.Forms.Padding(2);
            this.LBAssetViewer.Name = "LBAssetViewer";
            this.LBAssetViewer.Size = new System.Drawing.Size(361, 277);
            this.LBAssetViewer.TabIndex = 12;
            this.LBAssetViewer.SelectedIndexChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(655, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 46);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(101, 15);
            this.LTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(408, 29);
            this.LTitle.TabIndex = 9;
            this.LTitle.Text = "Digital Asset Management System";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(64, 75);
            this.tbKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(138, 19);
            this.tbKeyword.TabIndex = 20;
            // 
            // LKeyword
            // 
            this.LKeyword.AutoSize = true;
            this.LKeyword.Location = new System.Drawing.Point(8, 77);
            this.LKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LKeyword.Name = "LKeyword";
            this.LKeyword.Size = new System.Drawing.Size(54, 13);
            this.LKeyword.TabIndex = 19;
            this.LKeyword.Text = "Keyword :";
            // 
            // GBFilters
            // 
            this.GBFilters.Controls.Add(this.comboBox1);
            this.GBFilters.Controls.Add(this.checkedListBox1);
            this.GBFilters.Controls.Add(this.label1);
            this.GBFilters.Controls.Add(this.btnSearch);
            this.GBFilters.Location = new System.Drawing.Point(9, 116);
            this.GBFilters.Margin = new System.Windows.Forms.Padding(2);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Padding = new System.Windows.Forms.Padding(2);
            this.GBFilters.Size = new System.Drawing.Size(191, 240);
            this.GBFilters.TabIndex = 18;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filters";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(5, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Location = new System.Drawing.Point(6, 17);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(176, 94);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sort By:";
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
            // NormalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 366);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.LKeyword);
            this.Controls.Add(this.GBFilters);
            this.Controls.Add(this.LBAssetViewer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.LTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NormalForm";
            this.Text = "NormalForm";
            this.Load += new System.EventHandler(this.NormalForm_Load);
            this.GBFilters.ResumeLayout(false);
            this.GBFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBAssetViewer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label LKeyword;
        private System.Windows.Forms.GroupBox GBFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
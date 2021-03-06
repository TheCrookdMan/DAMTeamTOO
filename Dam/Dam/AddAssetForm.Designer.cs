﻿namespace Dam
{
    partial class AddAssetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAsset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChangedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDocType = new System.Windows.Forms.ComboBox();
            this.btnBrowseAsset = new System.Windows.Forms.Button();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset:";
            // 
            // tbAsset
            // 
            this.tbAsset.Location = new System.Drawing.Point(93, 53);
            this.tbAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsset.Name = "tbAsset";
            this.tbAsset.ReadOnly = true;
            this.tbAsset.Size = new System.Drawing.Size(269, 22);
            this.tbAsset.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DocType:";
            // 
            // tbChangedBy
            // 
            this.tbChangedBy.Location = new System.Drawing.Point(93, 81);
            this.tbChangedBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChangedBy.Name = "tbChangedBy";
            this.tbChangedBy.ReadOnly = true;
            this.tbChangedBy.Size = new System.Drawing.Size(269, 22);
            this.tbChangedBy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Changed By:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(93, 110);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(269, 22);
            this.tbLocation.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location:";
            // 
            // cbDocType
            // 
            this.cbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocType.FormattingEnabled = true;
            this.cbDocType.Location = new System.Drawing.Point(93, 23);
            this.cbDocType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDocType.Name = "cbDocType";
            this.cbDocType.Size = new System.Drawing.Size(269, 24);
            this.cbDocType.TabIndex = 8;
            // 
            // btnBrowseAsset
            // 
            this.btnBrowseAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseAsset.Location = new System.Drawing.Point(368, 53);
            this.btnBrowseAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseAsset.Name = "btnBrowseAsset";
            this.btnBrowseAsset.Size = new System.Drawing.Size(37, 23);
            this.btnBrowseAsset.TabIndex = 9;
            this.btnBrowseAsset.Text = "...";
            this.btnBrowseAsset.UseVisualStyleBackColor = true;
            this.btnBrowseAsset.Click += new System.EventHandler(this.btnBrowseAsset_Click);
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseLocation.Location = new System.Drawing.Point(368, 110);
            this.btnBrowseLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(37, 23);
            this.btnBrowseLocation.TabIndex = 10;
            this.btnBrowseLocation.Text = "...";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(93, 142);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 142);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAssetForm
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBrowseLocation);
            this.Controls.Add(this.btnBrowseAsset);
            this.Controls.Add(this.cbDocType);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbChangedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAsset);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAssetForm";
            this.Text = "AddAssetForm";
            this.Load += new System.EventHandler(this.AddAssetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAsset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChangedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDocType;
        private System.Windows.Forms.Button btnBrowseAsset;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}
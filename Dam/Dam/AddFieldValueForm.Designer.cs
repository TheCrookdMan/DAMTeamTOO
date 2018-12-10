namespace Dam
{
    partial class AddFieldValueForm
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
            this.tbField = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbField
            // 
            this.tbField.Location = new System.Drawing.Point(44, 27);
            this.tbField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbField.Name = "tbField";
            this.tbField.Size = new System.Drawing.Size(182, 20);
            this.tbField.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(44, 59);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(8, 30);
            this.lblField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(33, 13);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Data:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 59);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFieldValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 95);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddFieldValueForm";
            this.Text = "AddFieldValueForm";
            this.Load += new System.EventHandler(this.AddFieldValueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbField;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnCancel;
    }
}
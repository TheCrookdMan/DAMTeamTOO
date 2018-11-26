namespace Dam
{
    partial class LoginEdit
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
            this.LBLoginViewer = new System.Windows.Forms.ListBox();
            this.editAdd = new System.Windows.Forms.Button();
            this.editDelete = new System.Windows.Forms.Button();
            this.editEdit = new System.Windows.Forms.Button();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(121, 26);
            this.LTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(155, 29);
            this.LTitle.TabIndex = 1;
            this.LTitle.Text = "Login Editor";
            // 
            // LBLoginViewer
            // 
            this.LBLoginViewer.FormattingEnabled = true;
            this.LBLoginViewer.Location = new System.Drawing.Point(156, 84);
            this.LBLoginViewer.Name = "LBLoginViewer";
            this.LBLoginViewer.Size = new System.Drawing.Size(228, 238);
            this.LBLoginViewer.TabIndex = 2;
            // 
            // editAdd
            // 
            this.editAdd.Location = new System.Drawing.Point(13, 84);
            this.editAdd.Name = "editAdd";
            this.editAdd.Size = new System.Drawing.Size(137, 59);
            this.editAdd.TabIndex = 3;
            this.editAdd.Text = "Add";
            this.editAdd.UseVisualStyleBackColor = true;
            // 
            // editDelete
            // 
            this.editDelete.Location = new System.Drawing.Point(13, 171);
            this.editDelete.Name = "editDelete";
            this.editDelete.Size = new System.Drawing.Size(137, 59);
            this.editDelete.TabIndex = 4;
            this.editDelete.Text = "Delete";
            this.editDelete.UseVisualStyleBackColor = true;
            // 
            // editEdit
            // 
            this.editEdit.Location = new System.Drawing.Point(13, 263);
            this.editEdit.Name = "editEdit";
            this.editEdit.Size = new System.Drawing.Size(137, 59);
            this.editEdit.TabIndex = 5;
            this.editEdit.Text = "Edit";
            this.editEdit.UseVisualStyleBackColor = true;
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Location = new System.Drawing.Point(299, 21);
            this.btnEditLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(85, 46);
            this.btnEditLogin.TabIndex = 6;
            this.btnEditLogin.Text = "Return";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            // 
            // LoginEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 332);
            this.Controls.Add(this.btnEditLogin);
            this.Controls.Add(this.editEdit);
            this.Controls.Add(this.editDelete);
            this.Controls.Add(this.editAdd);
            this.Controls.Add(this.LBLoginViewer);
            this.Controls.Add(this.LTitle);
            this.Name = "LoginEdit";
            this.Text = "LoginEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.ListBox LBLoginViewer;
        private System.Windows.Forms.Button editAdd;
        private System.Windows.Forms.Button editDelete;
        private System.Windows.Forms.Button editEdit;
        private System.Windows.Forms.Button btnEditLogin;
    }
}
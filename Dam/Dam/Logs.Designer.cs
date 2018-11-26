namespace Dam
{
    partial class Logs
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
            this.LVLog = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVLog
            // 
            this.LVLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUser,
            this.chActivity,
            this.chDateTime});
            this.LVLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVLog.Location = new System.Drawing.Point(3, 16);
            this.LVLog.Name = "LVLog";
            this.LVLog.Size = new System.Drawing.Size(704, 352);
            this.LVLog.TabIndex = 2;
            this.LVLog.UseCompatibleStateImageBehavior = false;
            this.LVLog.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LVLog);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 371);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // chUser
            // 
            this.chUser.Text = "User";
            this.chUser.Width = 105;
            // 
            // chActivity
            // 
            this.chActivity.Text = "Activity";
            this.chActivity.Width = 408;
            // 
            // chDateTime
            // 
            this.chDateTime.Text = "Date & Time";
            this.chDateTime.Width = 187;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAM System - Log";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LVLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader chUser;
        private System.Windows.Forms.ColumnHeader chActivity;
        private System.Windows.Forms.ColumnHeader chDateTime;
    }
}
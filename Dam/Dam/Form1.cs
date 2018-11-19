using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Dam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Admin> adminUsers = db.Admins.ToList();

                foreach (Admin user in adminUsers)
                {
                    if (tbUsername.Text == user.AdminName && 
                        tbPassword.Text == user.AdminPassword)
                    {
                        MessageBox.Show("Logged In!", "DAM System - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("Invalid Login Details!", "DAM System - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class LoginForm : Form
    {
        
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Admin> adminUser = db.Admins.ToList();
                foreach (Admin user in adminUser)
                {
                    if (tbUsername.Text == user.AdminName &&
                        tbPassword.Text == user.AdminPassword)
                    {
                        MessageBox.Show("Logged In!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (user.Position == "Admin")
                        {
                            AdminForm mainForm = new AdminForm();
                            
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            NormalForm mainForm = new NormalForm();
                            
                            mainForm.Show();
                            this.Hide();
                        }
                        return;
                    }
                }
                MessageBox.Show("Invalid Login Details!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

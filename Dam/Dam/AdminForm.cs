using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dam
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

                this.Hide();
                LoginForm login = new LoginForm();

                login.Login += new EventHandler(LoginForm_login);
                login.Cancel += new EventHandler(LoginForm_Cancel);

                login.Show();
            }
            private void LoginForm_login(object sender, EventArgs args)
            {
                this.Show();

            }

            private void LoginForm_Cancel(object sender, EventArgs args)
            {
                Application.Exit();

            }
        }
}

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
    public partial class NormalForm : Form
    {
        public NormalForm()
        {
            InitializeComponent();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        
        {
           
            this.Hide();
            LoginForm login = new LoginForm();


            login.Show();
        }

        private void NormalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NormalForm_Load(object sender, EventArgs e)
        {

        }
    }
}

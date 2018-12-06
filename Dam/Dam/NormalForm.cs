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

        private void NormalForm_Load(object sender, EventArgs e)
        {
            using (DB _context = new DB())
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Search All");
                checkedListBox1.SetItemChecked(0, true);
                foreach (var item in _context.Documents.ToList())
                {
                    checkedListBox1.Items.Add(item);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            using (DB _context = new DB())
            {
                comboBox1.Items.Clear();
                if ((sender as CheckedListBox).SelectedItem.ToString() == "Search All")
                {
                    int _id = ((sender as CheckedListBox).SelectedItem as Documents).ID;

                   //// foreach (var item in _context.Field_Mappings.Include("doc").ToList().Distinct(new Field_Comp))
                   //// {
                   //     comboBox1.Items.Add(item);

                   // }
                }
                else
                {
                    int _id = ((sender as CheckedListBox).SelectedItem as Documents).ID;
                    foreach (var item in _context.Field_Mappings.Include("doc").Where(f => f.doc.ID == _id).ToList())
                    {
                        comboBox1.Items.Add(item);

                    }

                }
            }
        }

        private void NormalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

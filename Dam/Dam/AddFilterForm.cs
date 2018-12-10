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
    public partial class AddFilterForm : Form
    {
        public AddFilterForm()
        {
            InitializeComponent();
            addButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        public string getItem()
        {
            return filterNameTB.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool FilledIn()
        {
            if (cbDocType.SelectedIndex > 0)
            {
                if (filterNameTB.Text != null)
                {
                    return true;
                }
            }
            MessageBox.Show("Please fill in the required fields");
            return false;
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            //DialogResult.OK;
        }

        private void AddFilterForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                foreach (Documents item in db.Documents)
                {
                    cbDocType.Items.Add(item);
                }
            }
        }
    }
}

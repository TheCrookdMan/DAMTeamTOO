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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {

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

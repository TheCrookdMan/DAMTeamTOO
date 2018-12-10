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
    public partial class RemoveDocumentForm : Form
    {
        public RemoveDocumentForm()
        {
            InitializeComponent();
        }

        private DB db;

        private void RemoveDocumentForm_Load(object sender, EventArgs e)
        {
            foreach (Documents Types in db.Documents)
            {
                cbTypes.Items.Add(Types);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbTypes.SelectedIndex >= 0)
            {
                foreach (Documents Type in db.Documents)
                {
                    if (Type.ID == ((Documents)cbTypes.SelectedItem).ID)
                    {
                        db.Documents.Remove(Type);
                        db.SaveChanges();
                        Close();
                    }
                }
            }            
        }
    }
}

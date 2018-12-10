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

        private DB db = new DB();

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
                foreach (Field_Mappings field in db.Field_Mappings)
                {
                    if (field.doc.ID == ((Documents)cbTypes.SelectedItem).ID)
                    {
                        db.Field_Mappings.Remove(field);
                    }
                }
                foreach (Documents Type in db.Documents)
                {
                    
                    if (Type.ID == ((Documents)cbTypes.SelectedItem).ID)
                    {
                        db.Documents.Remove(Type);
                        Close();
                    }
                }
            }
            db.SaveChanges();
        }
    }
}

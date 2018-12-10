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
    public partial class AddDocumentForm : Form
    {
        public AddDocumentForm()
        {
            InitializeComponent();
        }

        private DB db = new DB();
        private int i;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Documents Document = new Documents();
            Document.Docname = tbDocName.Text;

            List<Field_Mappings> fields = new List<Field_Mappings>();


            i = 0;
            while (i != nmFieldCount.Value)
            {
                Field_Mappings field = new Field_Mappings();

                AddFieldMappingForm fieldMappingForm = new AddFieldMappingForm();
                fieldMappingForm.FieldNum = i.ToString();
                fieldMappingForm.ShowDialog();

                if (fieldMappingForm.FieldName != null)
                {
                    field.Field = fieldMappingForm.FieldName;
                    field.doc = Document;
                    fields.Add(field);
                }
                i++;
            }
            foreach (Field_Mappings field in fields)
            {
                db.Field_Mappings.Add(field);
            }

            Document.Fields = fields;
            db.Documents.Add(Document);

            db.SaveChanges();

            Close();
        }
    }
}

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
    public partial class AddFieldMappingForm : Form
    {
        public AddFieldMappingForm()
        {
            InitializeComponent();
        }

        public string FieldName;
        public string FieldNum;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FieldName = tbName.Text;
            Close();
        }

        private void AddFieldMappingForm_Load(object sender, EventArgs e)
        {
            lbNum.Text = FieldNum;
        }
    }
}
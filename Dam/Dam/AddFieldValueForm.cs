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
    public partial class AddFieldValueForm : Form
    {
        public AddFieldValueForm()
        {
            InitializeComponent();
        }
        public string FieldValue;
        public string label;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FieldValue = tbField.Text;
            Close();
        }

        private void AddFieldValueForm_Load(object sender, EventArgs e)
        {
            lblField.Text = label + " :";
        }
    }
}

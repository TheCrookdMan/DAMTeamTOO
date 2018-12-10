using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dam
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        public Admin User;

        private void AddAssetForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                foreach (Documents item in db.Documents)
                {
                    cbDocType.Items.Add(item);
                }
                tbChangedBy.Text = User.AdminName;
            }
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            Assets NewAsset = new Assets();

            using (DB db = new DB())
            {
                if (FilledIn() == true)
                {
                    NewAsset.Location = tbLocation.Text;

                    NewAsset.CapturedBy = User;

                    NewAsset.CapturedDate = DateTime.Now;

                    NewAsset.DocID = (Documents)cbDocType.SelectedItem;

                    foreach (Documents item in db.Documents)
                    {
                        if (item == cbDocType.SelectedItem)
                        {
                            foreach (Field_Mappings fields in item.Fields)
                            {
                                AddFieldValueForm AddValue = new AddFieldValueForm();
                                AddValue.label = fields.Field;
                                AddValue.ShowDialog();

                                if (AddValue.FieldValue != null)
                                {
                                    Metadata NewMeta = new Metadata();
                                    NewMeta.document = (Documents)cbDocType.SelectedItem;
                                    NewMeta.FieldValue = AddValue.FieldValue;
                                    NewMeta.AssetMeta = NewAsset;
                                    NewMeta.FieldMeta = fields;

                                    NewAsset.meta.Add(NewMeta);

                                    db.Metadatas.Add(NewMeta);
                                }
                            }
                        }
                    }
                    db.Assets.Add(NewAsset);
                    db.SaveChanges();
                }                
            }          
        }

        private bool FilledIn()
        {
            if (cbDocType.SelectedIndex >= 0)
            {
                if (tbAsset.Text != null)
                {
                    if (tbLocation.Text != null)
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show("Please fill in required fields");
            return false;
        }

        private void btnBrowseAsset_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (open.FileName != null)
            {
                tbAsset.Text = open.FileName;
            }
        }

        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            if (folderBrowser.SelectedPath != null)
            {
                tbLocation.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

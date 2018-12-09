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

        private void AddAssetForm_Load(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                foreach (Documents item in db.Documents)
                {
                    cbDocType.Items.Add(item);
                }
            }
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                if (FilledIn() == true)
                {
                    Assets Asset = new Assets();
                    Admin Dummy = new Admin();

                    Asset.Location = tbLocation.Text;
                    Asset.CapturedBy = Dummy;
                    Asset.CapturedDate = DateTime.Now;
                    Asset.DocID = (Documents)cbDocType.SelectedItem;

                    foreach (Metadata item in lbMetaData.Items)
                    {
                        Asset.meta.Add(item);
                    }

                    File.Move(tbAsset.Text, tbLocation.Text);

                    db.Assets.Add(Asset);
                    db.SaveChanges();
                }                
            }          
        }

        private bool FilledIn()
        {
            if (cbDocType.SelectedIndex > 0)
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

        private void btnRemoveMeta_Click(object sender, EventArgs e)
        {
            lbMetaData.Items.Remove(lbMetaData.SelectedItem);
        }
    }
}

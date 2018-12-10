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
        private string FileExtension;
        private string AssetName;

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
                    string FolderPath;
                    string FilePath;
                    NewAsset.CapturedDate = DateTime.Now;

                    FolderPath = tbLocation.Text + "\\";
                    FilePath = FolderPath + AssetName + "(Moved_Asset)" + FileExtension;

                    NewAsset.Location = FilePath;

                    NewAsset.CapturedBy = User;


                    foreach (Documents document in db.Documents)
                    {
                        if (document.ID == ((Documents)cbDocType.SelectedItem).ID)
                        {
                            NewAsset.DocID = document;
                            
                        }
                    }
                    foreach (Field_Mappings fields in db.Field_Mappings)
                    {
                        if (fields.doc.ID == ((Documents)cbDocType.SelectedItem).ID)
                        {
                            Metadata Data = new Metadata();

                            AddDataForm AddData = new AddDataForm();
                            AddData.label = fields.Field;
                            AddData.ShowDialog();

                            if (AddData.FieldValue != null)
                            {
                                Data.FieldValue = AddData.FieldValue;
                            }

                            Data.FieldMeta = fields;
                            Data.AssetMeta = NewAsset;

                            db.Metadatas.Add(Data);
                        }
                    }
                    db.Assets.Add(NewAsset);

                    File.Move(tbAsset.Text,FilePath);

                    db.SaveChanges();
                    Close();
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
                FileExtension = Path.GetExtension(open.FileName);
                AssetName = Path.GetFileNameWithoutExtension(open.FileName);
            }
        }

        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"\\25.16.124.220\TeamToo";
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

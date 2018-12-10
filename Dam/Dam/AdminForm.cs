using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dam
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public Admin LoggedInUser;

        private void btnLogout_Click(object sender, EventArgs e)
        {

                this.Hide();
                LoginForm login = new LoginForm();


                login.Show();
            }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            AddAssetForm addAsset = new AddAssetForm();
            addAsset.User = LoggedInUser;
            addAsset.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Logs newlog = new Logs();
            newlog.Show();
        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            LoginEdit editlog = new LoginEdit();
            editlog.Show();
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (LBAssetViewer.SelectedItem != null)
            {
                LBAssetViewer.Items.Remove(LBAssetViewer.SelectedItem);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Assets> bAssets = db.Assets.ToList();
                List<Documents> bDocuments = db.Documents.ToList();
                List<Field_Mappings> bFieldMappings = db.Field_Mappings.ToList();
                List<Metadata> bMetadatas = db.Metadatas.ToList();
                List<Admin> bAdmins = db.Admins.ToList();

                string backupPath = @"\\25.16.124.220\TeamToo\Backups\Manual\";
                string path = backupPath + DateTime.Now.Year.ToString() + "-" + DateTime.Now.ToString("ddhhmmss") + ".txt";
                File.Create(path).Close();
                TextWriter tw = new StreamWriter(path, true);

                foreach (Assets asset in bAssets)
                {
                    tw.WriteLine($"ASSET-{asset.ID}-{asset.DocID}-{asset.CapturedBy.AdminName}-{asset.CapturedDate}-{asset.Location}");
                }
                foreach (Documents doc in bDocuments)
                {
                    tw.WriteLine($"DOCUMENTS-{doc.ID}-{doc.Asset}-{doc.Docname}-{doc.Fields}");
                }
                foreach (Field_Mappings field in bFieldMappings)
                {
                    tw.WriteLine($"FIELD_MAPPINGS-{field.ID}-{field.doc}-{field.Field}-{field.MetaField}");
                }
                foreach (Metadata data in bMetadatas)
                {
                    tw.WriteLine($"METADATA-{data.ID}-{data.document}-{data.AssetMeta}-{data.FieldValue}-{data.FieldMeta}");
                }
                foreach (Admin admin in bAdmins)
                {
                    tw.WriteLine($"ADMIN-{admin.ID}-{admin.AdminName}-{admin.AdminPassword}-{admin.CapturedAssets}-{admin.DOB.ToString("yyyy/mm/dd")}-{admin.PhoneNo}-{admin.Position}");
                }

                tw.Close();
                MessageBox.Show("Backup successful!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addAF_Click(object sender, EventArgs e)
        {
            AddFilterForm addFilterForm = new AddFilterForm();
            if (addFilterForm.ShowDialog(this) == DialogResult.OK)
            {
                filtersListBox.Items.Add(addFilterForm.getItem());
            }
            addFilterForm.Close();
            //addFilterForm.ShowDialog();
        }

        private void deleteAF_Click(object sender, EventArgs e)
        {
            DeleteFilterForm deleteFilterForm = new DeleteFilterForm();
            if (deleteFilterForm.ShowDialog(this) == DialogResult.OK)
            {
                filtersListBox.Items.Remove(deleteFilterForm.getItem());
            }
            deleteFilterForm.Close();
            //deleteFilterForm.ShowDialog();
        }

        private void filtersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < filtersListBox.Items.Count; i++)
            {
                filtersListBox.SetItemChecked(i, false);
            }
            filtersListBox.SetItemChecked(filtersListBox.SelectedIndex, true);
            using (DB _context = new DB())
            {
                sortByBox.Items.Clear();
                if ((sender as CheckedListBox).SelectedItem.ToString() == "Search All")
                {
                    foreach (var item in _context.Field_Mappings.Include("doc").ToList().Distinct(new Field_Comp()))
                    {
                        sortByBox.Items.Add(item);
                    }
                }
                else
                {
                    int _id = ((sender as CheckedListBox).SelectedItem as Documents).ID;
                    foreach (var item in _context.Field_Mappings.Include("doc").Where(f => f.doc.ID == _id).ToList())
                    {
                        sortByBox.Items.Add(item);

                    }

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DB _context = new DB())
            {
                var Search = _context.Assets.Include("DocID").ToList();
            }
        }

        private void btnRemoveDoc_Click(object sender, EventArgs e)
        {
            RemoveDocumentForm RemoveDocument = new RemoveDocumentForm();
            RemoveDocument.ShowDialog();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            AddDocumentForm AddDocument = new AddDocumentForm();
            AddDocument.ShowDialog();
        }
    }
}

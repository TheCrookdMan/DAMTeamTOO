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

        private void btnLogout_Click(object sender, EventArgs e)
        {

                this.Hide();
                LoginForm login = new LoginForm();

                login.Login += new EventHandler(LoginForm_login);
                login.Cancel += new EventHandler(LoginForm_Cancel);

                login.Show();
            }
            private void LoginForm_login(object sender, EventArgs args)
            {
                this.Show();

            }

            private void LoginForm_Cancel(object sender, EventArgs args)
            {
                Application.Exit();

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
            try
            {
                if (LBAssetViewer.Items.Count >= 1)
                {
                    if (LBAssetViewer.SelectedValue != null)
                    {
                        string SAsset = LBAssetViewer.SelectedItem.ToString();
                        LBAssetViewer.Items.Remove(SAsset);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot remove");
                }
            }
            catch (Exception blop)
            {

            }
        }

        private int assetCount;
        private int docCount;
        private int fieldCount;
        private int metadataCount;
        private int adminCount;

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                List<Assets> bAssets = db.Assets.ToList();
                List<Documents> bDocuments = db.Documents.ToList();
                List<Field_Mappings> bFieldMappings = db.Field_Mappings.ToList();
                List<Metadata> bMetadatas = db.Metadatas.ToList();
                List<Admin> bAdmins = db.Admins.ToList();

                string backupPath = "\\\\DESKTOP-MK7928K\\TeamToo\\Backups\\Manual\\";
                string path = backupPath + DateTime.Now.Year.ToString() + "-" + DateTime.Now.ToString("ddhhmmss") + ".T2BACKUP";
                File.Create(path).Close();
                TextWriter tw = new StreamWriter(path, true);

                assetCount = 0;
                docCount = 0;
                fieldCount = 0;
                metadataCount = 0;
                adminCount = 0;

                foreach (Assets asset in bAssets)
                {
                    assetCount += 1;
                    tw.WriteLine($"ASSET-{assetCount}-{asset.ID}-{asset.DocID}-{asset.CapturedBy.AdminName}-{asset.CapturedDate}-{asset.Location}");
                }
                foreach (Documents doc in bDocuments)
                {
                    docCount += 1;
                    tw.WriteLine($"DOCUMENTS-{docCount}-{doc.ID}-{doc.Asset}-{doc.Docname}-{doc.Fields}");
                }
                foreach (Field_Mappings field in bFieldMappings)
                {
                    fieldCount += 1;
                    tw.WriteLine($"FIELD_MAPPINGS-{fieldCount}-{field.ID}-{field.doc}-{field.Field}-{field.MetaField}");
                }
                foreach (Metadata data in bMetadatas)
                {
                    metadataCount += 1;
                    tw.WriteLine($"METADATA-{metadataCount}-{data.ID}-{data.document}-{data.AssetMeta}-{data.FieldValue}-{data.FieldMeta}");
                }
                foreach (Admin admin in bAdmins)
                {
                    adminCount += 1;
                    tw.WriteLine($"ADMIN-{adminCount}-{admin.AdminName}-{admin.AdminPassword}-{admin.CapturedAssets}-{admin.DOB.ToString("yyyy/mm/dd")}-{admin.ID}-{admin.PhoneNo}-{admin.Position}");
                }

                tw.Close();
                MessageBox.Show("Backup successful!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

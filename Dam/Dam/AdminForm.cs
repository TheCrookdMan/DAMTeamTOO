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


                login.Show();
            }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            throw new Exception("OwO what is this? A error message? Hmmmmmmmm....wait, no please. Don't do it. Fix this shit");
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

                string backupPath = "\\\\DESKTOP-MK7928K\\TeamToo\\Backups\\Manual\\";
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
    }
}

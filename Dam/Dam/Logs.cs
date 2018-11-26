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
    public partial class Logs : Form
    {
        public List<Log> ActivityLog = new List<Log>();
        public Logs()
        {
            InitializeComponent();
        }

        public void RecordLog(string input, Admin user)
        {
            Log newLog = new Log();
            newLog.User = user.AdminName;
            newLog.Activity = input;
            newLog.DateAndTime = DateTime.Now;
            ActivityLog.Add(newLog);
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            foreach (Log log in ActivityLog)
            {
                LVLog.Items.Add(log.User).SubItems.AddRange(new string[]
                {
                    log.Activity,
                    log.DateAndTime.ToShortDateString() + " " + log.DateAndTime.ToShortTimeString()
                });
            }
        }
    }
}

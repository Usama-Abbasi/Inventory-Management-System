using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace IMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path + "\\connect"))
            {
                login log = new login();
                MainClass.showWindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.showWindow(set, this);
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.showWindow(set, this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.logOutToolStripMenuItem.Enabled = false;
            login i = new login();
            MainClass.showWindow(i, this);
            
        }
    }
}

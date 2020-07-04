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

namespace IMS
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (checkBox1.Checked)
            {
                if (serverTxt.Text != "" && dbTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Saved Successfully....", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill above fields");
                }
            }
            else
            {
                if (serverTxt.Text != "" && dbTxt.Text != "" && userTxt.Text != "" && passTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";User ID="+userTxt.Text+";Password="+passTxt+";";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Saved Successfully....", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill above fields");
                }

            }
            
        }
    }
}

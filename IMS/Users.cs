using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : Sample2
    {
        Retrieval r = new Retrieval();
        int edit = 0;
        int userId;
        short stat;
        public Users()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { namelabelError.Visible = true; } else { namelabelError.Visible = false; }
            if (userTxt.Text == "") { usrlabelError.Visible = true; } else { usrlabelError.Visible = false; }
            if (passTxt.Text == "") { passlabelError.Visible = true; } else { passlabelError.Visible = false; }
            if (phoneTxt.Text == "") { phonelabelError.Visible = true; } else { phonelabelError.Visible = false; }
            if (emailTxt.Text == "") { emaillabelError.Visible = true; } else { emaillabelError.Visible = false; }
            if (statusCombo.SelectedIndex==-1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (namelabelError.Visible || usrlabelError.Visible || passlabelError.Visible || phonelabelError.Visible || emaillabelError.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
               
                if (statusCombo.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusCombo.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//Code for Save Operation 
                {
                    
                    Insertion i = new Insertion();
                    
                    
                    i.insertUser(nameTxt.Text, userTxt.Text, passTxt.Text, phoneTxt.Text, emailTxt.Text,stat);
                   
                    r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update recored", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (statusCombo.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusCombo.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUser(userId, nameTxt.Text, userTxt.Text, passTxt.Text, phoneTxt.Text, emailTxt.Text, stat);

                        r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);

                    }
                

                }

            }

        }

        public override void delBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to Delete recored", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(userId, "st_deleteUpdate", "@id");
                    r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV,searchTxt.Text);

            }
            else
            {
                r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV);

            }

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
               r.showUser(dataGridView1, USERGV, nameGV, usernameGV, passGV, EmailGV, PhoneGV, StatusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userId = Convert.ToInt32(row.Cells["USERGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                userTxt.Text = row.Cells["usernameGV"].Value.ToString();
                passTxt.Text = row.Cells["passGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusCombo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);


            }
        }
    }
}

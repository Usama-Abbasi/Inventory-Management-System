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
    public partial class categories : Sample2
    {
        Retrieval r = new Retrieval();
        int edit = 0;
        int catId;
        short stat;
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
            if (catagoryTxt.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }
            if (catCombo.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (catErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {

                if (catCombo.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (catCombo.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//Code for Save Operation 
                {

                    Insertion i = new Insertion();
                    i.insertCat(catagoryTxt.Text, stat);

                    r.showCategories(dataGridView1, catGV, nameGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update recored", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (catCombo.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (catCombo.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateCat(catId,catagoryTxt.Text,stat);

                        r.showCategories(dataGridView1, catGV, nameGV, StatusGV);
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
                    d.delete(catId, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catGV, nameGV, StatusGV);

                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catGV, nameGV, StatusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catId= Convert.ToInt32(row.Cells["catGV"].Value.ToString());
                catagoryTxt.Text = row.Cells["nameGV"].Value.ToString();
                catCombo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);


            }
        }
    }
}

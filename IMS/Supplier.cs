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
    public partial class Supplier : Sample2
    {
        Retrieval r = new Retrieval();
        int edit = 0;
        int supplierId;
        short stat;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
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
            if (supplierTxt.Text == "") { suppierErrorLabel.Visible = true; } else { suppierErrorLabel.Visible = false; }
            if (contactPersonTxt.Text == "") { contactpersonErrorlabe.Visible = true; } else { contactpersonErrorlabe.Visible = false; }
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (suppierErrorLabel.Visible || contactpersonErrorlabe.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {

                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//Code for Save Operation 
                {

                    Insertion i = new Insertion();
                    if (phone2Txt.Text == "" && ntnTxt.Text != "")
                    {
                        i.insertSupplier(supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                    }
                    else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                    }
                    r.showSupplier(dataGridView1, supidGV, companyGV, contactpersonGV, phone1GV, phone2GV, addressGV, StatusGV, NTNGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update recored", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();


                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (edit == 1)//Code for Save Operation 
                        {


                            if (phone2Txt.Text == "" && ntnTxt.Text != "")
                            {
                                u.updateSupplier(supplierId, supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                            }
                            else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                            {
                                u.updateSupplier(supplierId, supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                            }
                            else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                            {
                                u.updateSupplier(supplierId, supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                            }
                            else
                            {
                                u.updateSupplier(supplierId, supplierTxt.Text, contactPersonTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                            }
                            r.showSupplier(dataGridView1, supidGV, companyGV, contactpersonGV, phone1GV, phone2GV, addressGV, StatusGV, NTNGV);
                            MainClass.disable_reset(leftPanel);

                        }


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
                    d.delete(supplierId, "st_deleteSupplier", "@supplierID");
                    r.showSupplier(dataGridView1, supidGV, companyGV, contactpersonGV, phone1GV, phone2GV, addressGV, StatusGV, NTNGV);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
           

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSupplier(dataGridView1, supidGV, companyGV, contactpersonGV, phone1GV, phone2GV, addressGV, StatusGV, NTNGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierId = Convert.ToInt32(row.Cells["supidGV"].Value.ToString());
                supplierTxt.Text = row.Cells["companyGV"].Value.ToString();
                contactPersonTxt.Text = row.Cells["contactpersonGV"].Value.ToString();
                phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                ntnTxt.Text = row.Cells["NTNGV"].Value.ToString();

                MainClass.disable(leftPanel);


            }
        }
    }
}

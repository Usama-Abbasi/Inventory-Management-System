using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Product : Sample2
    {
        Retrieval r = new Retrieval();
        int edit = 0;
        int prodId;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getlist("st_getCategorylist", categoryCombo, "Category", "ID");

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
            if(proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }
            if (barTxt.Text == "") { barErrorLabel.Visible = true; } else { barErrorLabel.Visible = false; }
            if (expireTxt.Value < DateTime.Now) { expErrorLabel.Visible = true; } else { expErrorLabel.Visible = false; }
            if (expireTxt.Value.Date == DateTime.Now.Date) { expErrorLabel.Visible = false; }
            if (priceTxt.Text == "") { priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
            if (categoryCombo.SelectedIndex == -1 || categoryCombo.SelectedIndex ==0) { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            if (proErrorLabel.Visible || barErrorLabel.Visible || priceErrorLabel.Visible || catErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {

                
                if (edit == 0)//Code for Save Operation 
                {

                    Insertion i = new Insertion();
                    if (expireTxt.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(proTxt.Text, barTxt.Text, Convert.ToSingle(priceTxt.Text),Convert.ToInt32(categoryCombo.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(proTxt.Text, barTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCombo.SelectedValue), expireTxt.Value);
                    }
                   

                    r.showProduct(dataGridView1, proidGV, productGV, barGV, expiryGV, priceGV, categoryGV,catidGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//Code for Update Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update recored", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (expireTxt.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(prodId, proTxt.Text, barTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCombo.SelectedValue));

                        }
                        else
                        {
                            u.updateProduct(prodId, proTxt.Text, barTxt.Text, Convert.ToSingle(priceTxt.Text),  Convert.ToInt32(categoryCombo.SelectedValue), expireTxt.Value);

                        }

                        r.showProduct(dataGridView1, proidGV, productGV, barGV, expiryGV, priceGV, categoryGV, catidGV);
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
                    d.delete(prodId, "st_deleteProduct", "@proID");
                    r.showProduct(dataGridView1, proidGV, productGV, barGV, expiryGV, priceGV, categoryGV, catidGV);

                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProduct(dataGridView1, proidGV, productGV, barGV, expiryGV, priceGV, categoryGV, catidGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex !=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodId = Convert.ToInt32(row.Cells["proidGV"].Value.ToString());
                proTxt.Text = row.Cells["productGV"].Value.ToString();
                barTxt.Text = row.Cells["barGV"].Value.ToString();
                if (row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expireTxt.Value = DateTime.Now;
                }
                else
                {
                    expireTxt.Value = DateTime.ParseExact(row.Cells["expiryGV"].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                }
               // expireTxt.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                categoryCombo.SelectedValue= row.Cells["catidGV"].Value.ToString();
                MainClass.disable(leftPanel);


            }
        }
    }
}

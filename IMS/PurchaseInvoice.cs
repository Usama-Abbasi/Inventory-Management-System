using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoice : Sample2
    {
        Retrieval r = new Retrieval();
        int productID;
        Regex reg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getlist("st_getSupplier_list", suppllierDD, "Company", "ID");
        }
        string[] productRR = new string[4];
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTxt.Text != null)
            {
                productRR = r.getProductWRTBarcode(barcodeTxt.Text);
                proTxt.Text = productRR[1];
                pupTxt.Text = productRR[2];
                productID = Convert.ToInt32(productRR[0]);
                string barcode = productRR[3];
                proTxt.Enabled = false;
                pupTxt.Enabled = false;
                if (barcode!=null)
                {
                    qunatityTxt.Focus();
                }
            }
            else
            {
                productID = 0;
                proTxt.Text = "";
                pupTxt.Text = "";
                Array.Clear(productRR, 0, productRR.Length);
            }
        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void qunatityTxt_TextChanged(object sender, EventArgs e)
        {
            if (qunatityTxt.Text != "")
            {
                if (reg.Match(qunatityTxt.Text).Success)
                {
                    float quan, price, total;
                    quan = Convert.ToSingle(qunatityTxt.Text);
                    price = Convert.ToSingle(pupTxt.Text);
                    total = quan * price;
                    TotalLabe.Text = total.ToString("######.##");
                }
                else
                {
                    qunatityTxt.SelectAll();
                }
            }
            else
            {
                TotalLabe.Text = "0.00";
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
           
            if (barcodeTxt.Text == "") { barErrorLabel.Visible = true; } else { barErrorLabel.Visible = false; }
            if (qunatityTxt.Text == "") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false; }
            if (suppllierDD.SelectedIndex == -1 || suppllierDD.SelectedIndex == 0) { supErrorLabel.Visible = true; } else { supErrorLabel.Visible = false; }

            if (quantityErrorLabel.Visible || barErrorLabel.Visible || supErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productID, proTxt.Text, qunatityTxt.Text, pupTxt.Text, TotalLabe.Text);
            }
        }
    }
}

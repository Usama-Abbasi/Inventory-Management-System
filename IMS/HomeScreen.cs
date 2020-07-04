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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userLabel.Text = Retrieval.EMP_NAME;
            
            MDI.logOutToolStripMenuItem.Enabled = true;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            //Users user = new Users();
            Users t = new Users();

            MainClass.showWindow(t, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories t = new categories();

            MainClass.showWindow(t, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();

            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice p = new PurchaseInvoice();

            MainClass.showWindow(p, this, MDI.ActiveForm);
        }
    }
}

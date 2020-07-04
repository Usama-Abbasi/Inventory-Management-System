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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { unameErrorLabel.Visible = true; } else { unameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if (unameErrorLabel.Visible || passErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
               
                    if (Retrieval.getUserDetail(usernameTxt.Text, passTxt.Text))
                    {
                        HomeScreen obj = new HomeScreen();
                        MainClass.showWindow(obj, this, MDI.ActiveForm);
                    }
                    else
                    {

                    }

                
            }
            
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { unameErrorLabel.Visible = true; } else { unameErrorLabel.Visible = false; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }

        }
    }
}

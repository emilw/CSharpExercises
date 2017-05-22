using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         if (myLogin.Login != "" && myLogin.Password != "")
          {
          displayLabel.Text = "The information entered is:";
          loginLabel.Text =
          "Login: " + myLogin.Login;
          passwordLabel.Text =
          "Password: " + myLogin.Password;
          } // end if 
          else 
 displayLabel.Text = "Enter information above";
        }
    }
}

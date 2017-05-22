using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_8
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        public string Password { get; private set; }
        public string Login { get; private set; }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            var loginTextBox = (TextBox)sender;
            Login = loginTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            var passwordTextBox = (TextBox)sender;
            Password = passwordTextBox.Text;
        }
    }
}

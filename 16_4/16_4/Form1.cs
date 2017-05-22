using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var comparisonValue = txtValueA.Text.CompareTo(txtValueB.Text);
            var textCode = "IS EQUAL TO";

            if (comparisonValue > 0)
                textCode = "IS GREATER THAN";
            else if (comparisonValue < 0)
                textCode = "IS LESS THAN";

            txtResult.Text = String.Format("{0} {1} {2}", txtValueA.Text, textCode, txtValueB.Text);
        }
    }
}

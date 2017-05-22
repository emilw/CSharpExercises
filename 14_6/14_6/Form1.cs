using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fahrenheitInputText_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            calculateChange(textBox.Text);
        }

        private void calculateChange(String celsiusInput)
        {
            decimal fahrenheitInput = 0;
            Decimal.TryParse(celsiusInput, out fahrenheitInput);

            var celsius = (5.0m / 9.0m) * (fahrenheitInput - 32);
            lblCelsiusOutput.Text = String.Format("{0:N2}", celsius);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculateChange("0");
        }
    }
}

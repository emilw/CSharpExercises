using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call 
            string[] states = { "New Jersey", "Idaho", "Illinois",
 "Indiana", "Iowa", "Kansas", "Kentucky", "Maryland",
 "Massachusetts", "Michigan", "Wisconsin", "Wyoming",
 "Oregon", "Pennsylvania", "Rhode Island" };

            statesComboBox.Items.AddRange(states);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statesComboBox.Items.Count == 1)
            {
                MessageBox.Show("There is no items left in the states list. The program will shut down.");
                Environment.Exit(1);
            }
            removedStatesListBox.Items.Add(statesComboBox.SelectedItem.ToString());
            statesComboBox.Items.RemoveAt(statesComboBox.SelectedIndex);
        }
    }
}

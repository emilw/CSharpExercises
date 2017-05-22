using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_3
{
    public partial class CheckBoxTestForm : Form
    {
        public CheckBoxTestForm()
        {
            InitializeComponent();
        }

        // when the Bold CheckBox is clicked make text bold if not bold, 
        // if already bold make not bold 
        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
           new Font(outputLabel.Font.Name, outputLabel.Font.Size,
           outputLabel.Font.Style ^ FontStyle.Bold);
        } // end metod boldCheckBox_CheckedChanged 

        // when the Italic CheckBox is clicked make text 
        // italic if not italic, if already italic make not italic 
        private void italicCheckBox_CheckedChanged(
        object sender, EventArgs e)
        {
            outputLabel.Font =
            new Font(outputLabel.Font.Name, outputLabel.Font.Size,
            outputLabel.Font.Style ^ FontStyle.Italic);
        } // end method italicCheckBox_CheckedChanged 

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
           new Font(outputLabel.Font.Name, outputLabel.Font.Size,
           outputLabel.Font.Style ^ FontStyle.Underline);
        }

        private void strikeoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font =
           new Font(outputLabel.Font.Name, outputLabel.Font.Size,
           outputLabel.Font.Style ^ FontStyle.Strikeout);
        }
    }
}

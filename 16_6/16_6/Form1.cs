using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var pigifiedText = "";
            var shouldStartWithCapitalLetter = true;

            foreach (var word in textBox.Text.Split().Where(x => !String.IsNullOrWhiteSpace(x)))
            {
                pigifiedText += String.Format("{0} ", GetPigLatin(word, shouldStartWithCapitalLetter));
                shouldStartWithCapitalLetter = sentenceEndingCharacters.Contains(word.Last());
            }

            txtOutput.Text = pigifiedText;

        }

        private char[] sentenceEndingCharacters = { '.', '?', '!' };
        private char[] endOfWordCharacters = { '.', '?', '!', ',' };

        private string GetPigLatin(string word, bool startWithUpperCase)
        {
            if (word.Length > 1)
            {
                var firstLetter = word.First();
                var lastCharacter = word.Last();
                var rest = word.TrimStart(firstLetter);
                if (endOfWordCharacters.Contains(lastCharacter))
                    rest = rest.TrimEnd(lastCharacter);
                var pigifiedWord = String.Format("{0}{1}{2}", rest, firstLetter, "ay").ToLower();

                if (endOfWordCharacters.Contains(lastCharacter))
                    pigifiedWord += lastCharacter;

                if (startWithUpperCase)
                {
                    var capitalStartingLetter = pigifiedWord.First().ToString().ToUpper();
                    pigifiedWord = pigifiedWord.Substring(1);
                    pigifiedWord = String.Format("{0}{1}", capitalStartingLetter, pigifiedWord);
                }

                return pigifiedWord;
            }
            return word;
        }
    }
}

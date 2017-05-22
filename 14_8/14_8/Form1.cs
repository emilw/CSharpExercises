using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_8
{
    public partial class Form1 : Form
    {

        private GuessingGame guessingGameModel;

        public Form1()
        {
            InitializeComponent();
            guessingGameModel = new GuessingGame();
            StartNewGame();
        }

        private void StartNewGame()
        {
            txtGuess.Enabled = true;
            txtGuess.Text = "0";
            btnNewGame.Enabled = false;
            guessingGameModel.StartNewGame();
            lblResult.Text = "Start guessing!";
            this.BackColor = Color.Empty;
        }

        private void StopGame()
        {
            txtGuess.Enabled = false;
            btnNewGame.Enabled = true;
        }

        private void setColorStatus(bool isCold, bool isCorrect)
        {
            if (isCorrect)
                this.BackColor = Color.Green;
            else if (!isCold)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Blue;
        }


        private void processGuess(int guess)
        {

            var guessResult = guessingGameModel.MakeAGuess(guess);

            if(guessResult.IsCorrect)
            {
                lblResult.Text = "Correct!";
                StopGame();
            }
            else if (guessResult.IsHigher)
            {
                lblResult.Text = "To High!";
            }
            else
            {
                lblResult.Text = "To Low!";
            }
            setColorStatus(guessResult.IsCold, guessResult.IsCorrect);
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (((KeyEventArgs)e).KeyCode == Keys.Enter)
            {
                int guess = 0;
                var txtGuess = (TextBox)sender;
                Int32.TryParse(txtGuess.Text, out guess);
                processGuess(guess);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}

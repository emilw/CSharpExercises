using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_8
{
    public class GuessingGame
    {
        private Random secretNumberGenerator;
        private int secretNumber;
        private int lastGuess;

        public GuessingGame()
        {
            secretNumberGenerator = new Random();
        }

        public void StartNewGame()
        {
            secretNumber = secretNumberGenerator.Next(1, 1000);
        }

        public GuessResult MakeAGuess(int guess)
        {
            bool isHigh = false;
            bool correct = false;
            bool isCold = false;
            if (secretNumber < guess)
            {
                isHigh = true;
            }
            else if (secretNumber > guess)
            {
                isHigh = false;
            }
            else
            {
                correct = true;
            }

            var earlierDelta = Math.Abs(lastGuess - secretNumber);
            var currentDelta = Math.Abs(guess - secretNumber);

            if (earlierDelta > currentDelta)
                isCold = false;
            else
                isCold = true;

            var guessResult = new GuessResult(correct, isHigh, isCold);
            lastGuess = guess;

            return guessResult;
        }
    }
}

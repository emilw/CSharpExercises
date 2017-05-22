using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_8
{
    public class GuessResult
    {
        public GuessResult(bool isCorrect, bool isHigher, bool isCold)
        {
            IsCorrect = isCorrect;
            IsHigher = isHigher;
            IsCold = isCold;
        }

        public bool IsCorrect { get; private set; }
        public bool IsHigher { get; private set; }
        public bool IsCold { get; private set; }

    }
}

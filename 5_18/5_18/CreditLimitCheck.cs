using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18
{
    public class CreditLimitCheck
    {
        public CreditLimitCheck(int accountNumber, int balanceInBeginningOfMonth, int totalChargeThisMonth, int totalCreditThisMonth, int creditLimit)
        {
            AccountNumber = accountNumber;
            BalanceInBeginningOfMonth = balanceInBeginningOfMonth;
            TotalChargeThisMonth = totalChargeThisMonth;
            TotalCreditThisMonth = totalCreditThisMonth;
            CreditLimit = creditLimit;
        }

        public int AccountNumber { get; private set; }
        public int BalanceInBeginningOfMonth { get; private set; }
        public int TotalChargeThisMonth { get; private set; }
        public int TotalCreditThisMonth { get; private set; }
        public int CreditLimit { get; private set; }

        public bool IsCreditLimitExceeded
        {
            get
            {
                return TotalBalance < 0 ? true : false;
            }
        }

        public int CurrentMonthlyBalance
        {
            get
            {
                return (BalanceInBeginningOfMonth + TotalChargeThisMonth - TotalCreditThisMonth);
            }
        }

        public int TotalBalance
        {
            get
            {
                return CreditLimit + CurrentMonthlyBalance;
            }
        }
    }
}

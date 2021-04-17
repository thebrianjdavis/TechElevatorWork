using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public int Balance { get; private set; } = 0;
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt
        {
            get
            {
                return Balance * -1;
            }
        }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }
        public int Pay(int amountToPay)
        {
            return Balance += amountToPay;
        }
        public int Charge(int amountToCharge)
        {
            return Balance -= amountToCharge;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Balance { get; }
        public List<IAccountable> accountsList = new List<IAccountable>();
        public bool IsVip
        {
            get
            {
                bool vipTest = false;
                int totalBalance = 0;
                for (int i = 0; i < accountsList.Count; i++)
                {
                    totalBalance += accountsList[i].Balance;
                }
                if (totalBalance >= 25000)
                {
                    vipTest = true;
                }
                return vipTest;
            }
        }
        public BankCustomer()
        {

        }
        public void AddAccount(IAccountable newAccount)
        {
            accountsList.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            return accountsList.ToArray();
        }
    }
}

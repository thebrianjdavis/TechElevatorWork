namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal serviceCharge = 2;
            if (Balance - amountToWithdraw >= 2)
            {
                base.Withdraw(amountToWithdraw);
                if (Balance < 150)
                {
                    base.Withdraw(serviceCharge);
                }
            }
            return Balance;
        }
    }
}

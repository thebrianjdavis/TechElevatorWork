namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal overdraftFee = 10;
            if (Balance - amountToWithdraw >= -90)
            {
                base.Withdraw(amountToWithdraw);
                if (Balance < 0)
                {
                    base.Withdraw(overdraftFee);
                }
            }
            return Balance;
        }
    }
}

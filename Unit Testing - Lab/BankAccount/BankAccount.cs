namespace BankAccount
{
    public class BankAccount
    {
        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }
        
        public decimal Amount { get; set; }
        
        public void Deposit(decimal deposit)
        {
            this.Amount += deposit;
        }
    }
}

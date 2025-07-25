namespace BankAccount.Models
{
    public class BankAccount
    {
        private decimal _balance;
        private decimal _amount;

        public int AccountNumber { get; set; }

        public decimal Balance { get => _balance; set => _balance = value; }
        public decimal Amount { get => _amount; set => _amount = value; }

        public void Withdraw()
        {
            _balance = (_balance - _amount);
        }
        public void Deposit()
        {
            _balance = (_balance + _amount);
        }
    }
}

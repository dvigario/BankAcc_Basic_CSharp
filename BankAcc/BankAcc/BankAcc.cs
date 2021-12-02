namespace BankAcc
{
    class BankAcc
    {
        public int AccNumber { get; private set; }
        public string AccName { get; set; }
        public double Balance { get; private set; }

        public BankAcc(int accNumber, string accName)
        {
            AccNumber = accNumber;
            AccName = accName;
        }

        public BankAcc(int accNumber, string accName, double balance) : this(accNumber, accName)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdrawal(double amount)
        {
            Balance -= amount + 2.0 // 2.0 = tax
        }

        public override string ToString()
        {
            return ($"Acc Number: {AccNumber}, Acc Name: {AccName}, Balance: £{Balance:F2}");
        }
    }
}

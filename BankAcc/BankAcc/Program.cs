using System;

namespace BankAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc;

            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the account holder: ");
            string accName = Console.ReadLine();

            Console.Write("Do you want to include some amount(y/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'y' || resp == 'Y')
            {
                Console.WriteLine("Enter the deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine());
                acc = new BankAcc(number, accName, initialDeposit);
            }
            else
            {
                acc = new BankAcc(number, accName);
            }

            Console.WriteLine();
            Console.WriteLine("Account information: ");
            Console.WriteLine(acc);
            // ===== Deposit ===== //
            Console.WriteLine();
            Console.Write("Enter the amount for the deposit: ");
            double amount = double.Parse(Console.ReadLine());
            acc.Deposit(amount);

            Console.WriteLine();
            Console.WriteLine("Account information: ");
            Console.WriteLine(acc);
            // ===== Withdraw ===== //
            Console.WriteLine();
            Console.Write("Enter the withdrawal amount: ");
            amount = double.Parse(Console.ReadLine());
            acc.Withdrawal(amount);

            Console.WriteLine();
            Console.WriteLine("Account information: ");
            Console.WriteLine(acc);

        }
    }
}

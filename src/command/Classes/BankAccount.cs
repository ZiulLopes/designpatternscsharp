using System;

namespace command.Classes
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimt = -45;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited $ {amount}, balance is now $ {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimt)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew $ {amount}, balance is now $ {balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
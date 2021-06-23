using System;
using command.Interfaces;
using command.Enums;

namespace command.Classes
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;

        private Enums.Action action;
        private int amount;
        private bool succeeded;

        public BankAccountCommand(BankAccount account, Enums.Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch (action)
            {
                case Enums.Action.Deposit:
                    account.Deposit(amount);
                    succeeded = true;
                    break;

                case Enums.Action.Withdraw:
                    succeeded = account.Withdraw(amount);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!succeeded) return;
            switch (action)
            {
                case Enums.Action.Deposit:
                    account.Withdraw(amount);
                    break;

                case Enums.Action.Withdraw:
                    account.Deposit(amount);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
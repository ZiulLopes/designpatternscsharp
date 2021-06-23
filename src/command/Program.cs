using System;
using System.Collections.Generic;
using System.Linq;
using command.Classes;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, Enums.Action.Deposit, 100),
                new BankAccountCommand(ba, Enums.Action.Deposit, 150),
                new BankAccountCommand(ba, Enums.Action.Withdraw, 50)
            };
            
            Console.WriteLine(ba);

            foreach (var command in commands)
                command.Call();

            Console.WriteLine(ba);

            foreach (var command in Enumerable.Reverse(commands))
                command.Undo();

            Console.WriteLine(ba);
        }
    }
}

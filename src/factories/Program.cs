using System;
using factories.Interfaces;
using factories.Factory;

namespace factories
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCardFactory = new CreditCardFactory();

            ICreditCard cardDetails = creditCardFactory.ReturnCredit("Titanium");

            Console.WriteLine($"Tipo de cartão: {cardDetails.GetCardType()}");
            Console.WriteLine($"Limite do cartão: R$ {cardDetails.GetCreditLimit()}");
        }
    }
}

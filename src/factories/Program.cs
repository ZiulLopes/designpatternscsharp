using System;
using factories.Factory;
using factories.Enums;

namespace factories
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCardFactory = new CreditCardFactory();

            var cardDetails = creditCardFactory.ReturnCredit(CreditCard.MoneyBack);

            Console.WriteLine($"Tipo de cartão: {cardDetails.GetCardType()}");
            Console.WriteLine($"Limite do cartão: R$ {cardDetails.GetCreditLimit()}");
        }
    }
}

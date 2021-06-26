using System;
using System.Collections.Generic;
using chainofresponsibility.Classes;
using chainofresponsibility.Handlers;
using chainofresponsibility.Models;

namespace chainofresponsibility
{
    class Program
    {
        
        public static List<string> Messages = new List<string>() {};

        static void Main(string[] args)
        {
            var userCreditCardVerified = new UserCreditCardVerified();
            var actualValueGretherThan200000 = new ActualValueGretherThan200000();
            var invalidHourUsedCard = new InvalidHourUsedCard();

            var userCreditCard = new UserCreditCardModel()
            {
                Id = 123,
                NameUser = "Luiz Lopesfff",
                CreditCardType = "Black",
                ActualValue = 195000,
                DateUsed = new DateTime(2021, 2, 22, 1, 0, 0)
            };

            userCreditCardVerified.SetNext(actualValueGretherThan200000).SetNext(invalidHourUsedCard);

            
            AbstractHandler handler = userCreditCardVerified;

            
            var result = handler.Handle(userCreditCard);

            Console.WriteLine(String.Join("", Messages));
        }
    }
}

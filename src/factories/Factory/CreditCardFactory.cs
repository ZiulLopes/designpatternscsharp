using System;
using factories.Classes;
using factories.Interfaces;

namespace factories.Factory
{
    public class CreditCardFactory
    {
        public ICreditCard ReturnCredit(string cardType)
        {
            switch (cardType)
            {
                case "MoneyBack":
                    return new MoneyBack();
                
                case "Titanium":
                    return new Titanium();

                case "Platinum":
                    return new Platinum();
            }
            return null;
        }
    }
}
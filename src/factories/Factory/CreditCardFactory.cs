using System;
using factories.Classes;
using factories.Interfaces;
using factories.Enums;

namespace factories.Factory
{
    public class CreditCardFactory
    {
        public ICreditCard ReturnCredit(CreditCard cardType)
        {
            switch (cardType)
            {
                case CreditCard.MoneyBack:
                    return new MoneyBack();
                
                case CreditCard.Titanium:
                    return new Titanium();

                case CreditCard.Platinum:
                    return new Platinum();
            }
            return null;
        }
    }
}
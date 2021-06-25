using System;
using factories.Interfaces;

namespace factories.Classes
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType() => "MoneyBack";
        public int GetCreditLimit() => 15000;
        public int GetAnnualCharge() => 500;
    }   
}
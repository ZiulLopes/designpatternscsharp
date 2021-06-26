using System;

namespace chainofresponsibility.Models
{
    public class UserCreditCardModel
    {
        public int Id { get; set; } 
        public string NameUser { get; set; }
        public string CreditCardType { get; set; }
        public int ActualValue { get; set; }
        public DateTime DateUsed { get; set; }
    }
}
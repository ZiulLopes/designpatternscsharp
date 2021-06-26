using System;
using System.Collections.Generic;
using chainofresponsibility.Handlers;
using chainofresponsibility.Models;

namespace chainofresponsibility.Classes
{
    public class InvalidHourUsedCard : AbstractHandler
    {
        public override object Handle(object request)
        {
            var response = new ResponseModel()
            {
                Code = 0,
                Data = "",
                Messages = new List<string>(){}
            };
            var hourUse = TimeSpan.Parse((request as UserCreditCardModel).DateUsed.ToShortTimeString());
            if (hourUse > TimeSpan.Parse("00:00") && hourUse < TimeSpan.Parse("04:00"))
            {
                response.Messages.Add($"Não é possível usar o cartão nesse horário!\n");
            }
            return base.Handle(request);
        }
    }
}
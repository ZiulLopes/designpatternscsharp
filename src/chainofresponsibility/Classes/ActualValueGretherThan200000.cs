using System;
using System.Collections.Generic;
using chainofresponsibility.Handlers;
using chainofresponsibility.Models;

namespace chainofresponsibility.Classes
{
    public class ActualValueGretherThan200000 : AbstractHandler
    {
        public override object Handle(object request)
        {   
            var actualValue = (request as UserCreditCardModel).ActualValue;
            if (actualValue < 200000)
            {
                Program.Messages.Add($"Saldo do usuário menor que R$ 200.000\n");
            }
            return base.Handle(request);
        }
    }
}
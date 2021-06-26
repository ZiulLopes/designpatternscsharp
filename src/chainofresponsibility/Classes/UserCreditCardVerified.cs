using System;
using System.Collections.Generic;
using chainofresponsibility.Handlers;
using chainofresponsibility.Models;

namespace chainofresponsibility.Classes
{
    public class UserCreditCardVerified : AbstractHandler
    {
        public override object Handle(object request)
        {
            var users = new List<string>(){ "Luiz Lopes", "Felipe", "Rodrigo" };
            var userSelected = (request as UserCreditCardModel).NameUser;
            if (!users.Contains(userSelected))
            {
                Program.Messages.Add($"Usuario {userSelected.ToString()} não existe na base!\n");
            }
            return base.Handle(request);
        }
    }
}
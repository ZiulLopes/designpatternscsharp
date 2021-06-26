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
            var response = new ResponseModel()
            {
                Code = 0,
                Data = "",
                Messages = new List<string>(){}
            };
            var users = new List<string>(){ "Luiz Lopes", "Felipe", "Rodrigo" };
            var userSelected = (request as UserCreditCardModel).NameUser;
            if (!users.Contains(userSelected))
            {
                response.Messages.Add($"Usuario {userSelected.ToString()} não existe na base!\n");
            }
            return base.Handle(request);
        }
    }
}
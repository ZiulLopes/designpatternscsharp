using System;
using SingleResponsibilityPrinciple.Classes;
using SingleResponsibilityPrinciple.Classes.Interfaces;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        private static ILogger _logger;
        private static IMail _mail;

        static void Main(string[] args)
        {
            _logger = new Logger();
            _mail = new Mail();
            
            Console.WriteLine(_logger.Info($"Iniciando aplicação"));

            if (!_mail.Send(new {email = "teste@email.com"}))
            {
                Console.WriteLine(_logger.Error("Error", new Exception("Erro ao enviar email")));
            }
            else
            {
                Console.WriteLine(_logger.Info($"Email enviado!"));
            }
        }
    }
}

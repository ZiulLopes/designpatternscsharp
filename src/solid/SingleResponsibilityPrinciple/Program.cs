using System;

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

    public interface ILogger
    {
        string Info(string info);
        string Debug(string info);
        string Error(string message, Exception ex);
    }

    public class Logger : ILogger
    {
        public string Debug(string message)
        {
            return $"Info: {message}";
        }

        public string Error(string message, Exception ex)
        {
            return $"Error: {message}\nException: {ex.Message}";
        }

        public string Info(string info)
        {
            return $"Info: {info}";
        }
    }

    public interface IMail
    {
        bool Send(object MailObject);
    }

    public class Mail : IMail
    {
        public bool Send(object MailObject)
        {
            return false;
        }
    }
}

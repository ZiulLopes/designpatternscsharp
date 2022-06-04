using System;

namespace adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPayPalPayment payment = new PayonnerAdapter(new PayonnerPayment());

            payment.PayPalPayment();
            payment.PayPalReceive();
        }
    }

    public interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }

    public class Token
    {
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudCI6IjEyMzQ1Njc4OTAiLCJuYW1lIjoiSm9obiBEb2UiLCJib3JuIjoiMjEvMTEvMTk5MSIsImFkcmVzcyI6InJ1In0.HNOksYM-J1LZOkvDVtQarHpsu77uKd70xImBpfgWo94";

        public string GetToken()
        {
            return token;
        }
    }

    public class PayPal : IPayPalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Sending payment...");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Receiving payment...");
        }
    }

    public interface IPayonnerPayment
    {
        Token AuthToken();

        void SendPayment();

        void ReceivePayment();
    }

    public class PayonnerPayment : IPayonnerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Receiving payment with Payonner...");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Sending payment with Payonner...");
        }
    }

    public class PayonnerAdapter : IPayPalPayment
    {
        private readonly PayonnerPayment _payonnerPayment;

        public PayonnerAdapter(PayonnerPayment payonnerPayment)
        {
            _payonnerPayment = payonnerPayment;   
        }

        public Token AuthToken()
        {
            return _payonnerPayment.AuthToken();
        }

        public void PayPalPayment()
        {
            _payonnerPayment.SendPayment();
        }

        public void PayPalReceive()
        {
            _payonnerPayment.ReceivePayment();
        }
    }
}

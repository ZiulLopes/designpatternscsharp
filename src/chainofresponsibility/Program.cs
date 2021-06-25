using System;
using System.Collections.Generic;

namespace chainofresponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            return null;
        }
    }

    public class Chain1 : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "teste1")
            {
                return $"Teste é esse {request.ToString()}\n";
            }
            return base.Handle(request);
        }
    }

    public class Chain2 : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "teste2")
            {
                return $"Teste é esse {request.ToString()}\n";
            }
            return base.Handle(request);
        }
    }

    public class Chain3 : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "teste3")
            {
                return $"Teste é esse {request.ToString()}\n";
            }
            return base.Handle(request);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var chain1 = new Chain1();
            var chain2 = new Chain2();
            var chain3 = new Chain3();

            chain1.SetNext(chain2).SetNext(chain3);

            
            AbstractHandler handler = chain1;

            foreach (var food in new List<string> { "teste1", "teste2", "banana" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}

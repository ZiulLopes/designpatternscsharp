using System;
using OpenClosedPrinciple.Classes;
using OpenClosedPrinciple.Classes.Interfaces;
using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var draw = DrawShape(Shape.Square);

            Console.WriteLine(draw.Drawing());
        }

        private static IDraw DrawShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.Circle:
                    return new Circle();
                case Shape.Square:
                    return new Square();                
                default:
                    return new Square();
            }
        }
    }
}

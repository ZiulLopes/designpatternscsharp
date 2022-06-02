using System;

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

    public enum Shape
    {
        None,
        Square,
        Circle
    }

    public interface IDraw
    {
        string Drawing();
    }

    public abstract class Draw : IDraw
    {
        public abstract string Drawing();
    }

    public class Square : IDraw
    {
        public string Drawing()
        {
            return $"Drawing a square";
        }
    }

    public class Circle : IDraw
    {
        public string Drawing()
        {
            return $"Drawing a circle";
        }
    }
}

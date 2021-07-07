using System;
using Builder.Builder;
using Builder.Classes;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalBuilder builder;

            Shop shop = new Shop();

            builder = new DogBuilder();
            shop.Construct(builder);
            builder.Animal.Show();
            Console.WriteLine(builder.Sound());

            builder = new CowBuilder();
            shop.Construct(builder);
            builder.Animal.Show();
            Console.WriteLine(builder.Sound());
        }
    }
}

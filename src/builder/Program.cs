using System;
using System.Collections.Generic;
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
            System.Console.WriteLine(builder.Sound());

            builder = new CowBuilder();
            shop.Construct(builder);
            builder.Animal.Show();
            System.Console.WriteLine(builder.Sound());
        }
    }
}

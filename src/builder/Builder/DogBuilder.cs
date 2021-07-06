using System;
using Builder.Classes;

namespace Builder.Builder
{
    public class DogBuilder : AnimalBuilder
    {
        public DogBuilder()
        {
            animal = new Animal("Dog");
        }

        public override string Sound()
        {
            return $"Som do animal: Woof";
        }
    }
}
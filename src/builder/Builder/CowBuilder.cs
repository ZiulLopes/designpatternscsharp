using System;
using Builder.Classes;

namespace Builder.Builder
{
    public class CowBuilder : AnimalBuilder
    {
        public CowBuilder()
        {
            animal = new Animal("Cow");
        }
        public override string Sound()
        {
            return $"Som do animal: Mooo";
        }
    }
}
using System;
using Builder.Classes;

namespace Builder.Builder
{
    public abstract class AnimalBuilder
    {
        protected Animal animal;

        public Animal Animal
        {
            get { return animal; }
        }

        public abstract string Sound();
    }
}
using System;
using Builder.Builder;

namespace Builder.Classes
{
    public class Shop
    {
        public void Construct(AnimalBuilder animalBuilder)
        {
            animalBuilder.Sound();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Builder.Classes
{
    public class Animal
    {
        private string _animalType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Animal(string animalType)
        {
            this._animalType = animalType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            System.Console.WriteLine($"Tipo de animal: {_animalType}");
        }
    }
}
using OpenClosedPrinciple.Classes.Interfaces;

namespace OpenClosedPrinciple.Classes
{
    public class Circle : IDraw
    {
        public string Drawing()
        {
            return $"Drawing a circle";
        }
    }
}
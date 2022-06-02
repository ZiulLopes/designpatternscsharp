using OpenClosedPrinciple.Classes.Interfaces;

namespace OpenClosedPrinciple.Classes
{
    public class Square : IDraw
    {
        public string Drawing()
        {
            return $"Drawing a square";
        }
    }
}
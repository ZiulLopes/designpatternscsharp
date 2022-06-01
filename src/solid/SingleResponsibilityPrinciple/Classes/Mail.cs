using SingleResponsibilityPrinciple.Classes.Interfaces;

namespace SingleResponsibilityPrinciple.Classes
{
    public class Mail : IMail
    {
        public bool Send(object MailObject)
        {
            return false;
        }
    }
}
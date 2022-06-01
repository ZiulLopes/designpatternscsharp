using System;

namespace SingleResponsibilityPrinciple.Classes.Interfaces
{
    public interface ILogger
    {
        string Info(string info);
        string Debug(string info);
        string Error(string message, Exception ex);
    }
}
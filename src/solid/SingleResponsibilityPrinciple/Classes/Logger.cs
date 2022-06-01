using System;
using SingleResponsibilityPrinciple.Classes.Interfaces;

namespace SingleResponsibilityPrinciple.Classes
{
    public class Logger : ILogger
    {
        public string Debug(string message)
        {
            return $"Info: {message}";
        }

        public string Error(string message, Exception ex)
        {
            return $"Error: {message}\nException: {ex.Message}";
        }

        public string Info(string info)
        {
            return $"Info: {info}";
        }
    }
}
using FactoryPatternDemo.Interfaces;

namespace FactoryPatternDemo.Services
{
    public class SMSNotification : INotification
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to} with message: {message}");
            return true;
        }
    }
}

using FactoryPatternDemo.Interfaces;

namespace FactoryPatternDemo.Services
{
    public class EmailNotification : INotification
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to} with message: {message}");
            return true;
        }
    }
}

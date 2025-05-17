using FactoryPatternDemo.Interfaces;

namespace FactoryPatternDemo.Services
{
    public class WhastsAppNotification : INotification
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine($"Sending WhatsApp message to {to} with message: {message}");
            return true;
        }
    }
}

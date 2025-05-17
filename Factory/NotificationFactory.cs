using FactoryPatternDemo.Interfaces;
using FactoryPatternDemo.Models;
using FactoryPatternDemo.Services;

namespace FactoryPatternDemo.Factory
{
    public class NotificationFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public NotificationFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => _serviceProvider.GetService<EmailNotification>()
                            ?? throw new InvalidOperationException("EmailNotification service is not registered."),
                "sms" => _serviceProvider.GetService<SMSNotification>()
                            ?? throw new InvalidOperationException("SMSNotification service is not registered."),
                "whatsapp" => _serviceProvider.GetService<WhastsAppNotification>()
                            ?? throw new InvalidOperationException("WhastsAppNotification service is not registered."),
                _ => throw new ArgumentException("Notification Type provided is Invalid")
            };
        }
    }
}

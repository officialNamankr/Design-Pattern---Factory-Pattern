namespace FactoryPatternDemo.Models.DTO
{
    public class NotificationRequest
    {
        public string Type { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

    }
}

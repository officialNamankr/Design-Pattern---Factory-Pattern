namespace FactoryPatternDemo.Interfaces
{
    public interface INotification
    {
       public bool Send(string to, string message);
    }
}

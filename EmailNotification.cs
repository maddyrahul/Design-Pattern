

namespace Design_Pattern
{
    public class EmailNotification : INotification
    {
        public void SendNotification(string subject, string message)
        {
            Console.WriteLine($"Sending Email: Subject: {subject}, Message: {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void SendNotification(string subject, string message)
        {
            Console.WriteLine($"Sending SMS: Subject: {subject}, Message: {message}");
        }
    }

}

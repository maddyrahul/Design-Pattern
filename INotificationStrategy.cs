namespace Design_Pattern
{
    public interface INotificationStrategy
    {
        void Send(string subject, string message);
    }

    public class EmailStrategy : INotificationStrategy
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"[Strategy] Email Sent: {subject} - {message}");
        }
    }

    public class SMSStrategy : INotificationStrategy
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"[Strategy] SMS Sent: {subject} - {message}");
        }
    }

    public class NotificationContext
    {
        private INotificationStrategy _strategy;

        public NotificationContext(INotificationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(string subject, string message)
        {
            _strategy.Send(subject, message);
        }
    }

}

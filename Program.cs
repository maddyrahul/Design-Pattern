using Design_Pattern;
public class Program
{
    public static void Main(string[] args)
    {
        // Simulating users subscribing to notifications
        var user1 = new User("Rahul");
        var user2 = new User("Neha");

        var publisher = new NotificationPublisher();
        publisher.Subscribe(user1);
        publisher.Subscribe(user2);

        // Publisher sends notifications to all subscribers
        publisher.NotifyAll("Important Update", "This is a notification message.");

        // Using Facade and Strategy Pattern for sending notifications
        var facade = new NotificationFacade();
        facade.Send("email", "Hello", "Email Notification");

        var context = new NotificationContext(new EmailStrategy());
        context.ExecuteStrategy("Email Subject", "This is a strategy email.");

        context = new NotificationContext(new SMSStrategy());
        context.ExecuteStrategy("SMS Subject", "This is a strategy SMS.");
    }
}

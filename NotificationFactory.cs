using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string channel)
        {
            switch (channel.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                default:
                    throw new ArgumentException("Invalid notification channel.");
            }
        }
    }

}

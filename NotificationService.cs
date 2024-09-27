using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class NotificationService
    {
        private static NotificationService _instance;
        private NotificationService() { }

        public static NotificationService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NotificationService();
            }
            return _instance;
        }

        public void Notify(string channel, string subject, string message)
        {
            INotification notification = NotificationFactory.CreateNotification(channel);
            notification.SendNotification(subject, message);
        }
    }

}

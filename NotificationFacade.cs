using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class NotificationFacade
    {
        private NotificationService _service;

        public NotificationFacade()
        {
            _service = NotificationService.GetInstance();
        }

        public void Send(string channel, string subject, string message)
        {
            _service.Notify(channel, subject, message);
        }
    }

}

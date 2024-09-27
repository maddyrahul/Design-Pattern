using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    // Existing service for third-party email system (not following INotification interface)
    public class ThirdPartyEmailService
    {
        public void SendEmail(string title, string body)
        {
            Console.WriteLine($"Third Party Email - Title: {title}, Body: {body}");
        }
    }

    // Adapter to make ThirdPartyEmailService compatible with INotification
    public class ThirdPartyEmailAdapter : INotification
    {
        private ThirdPartyEmailService _emailService;

        public ThirdPartyEmailAdapter(ThirdPartyEmailService emailService)
        {
            _emailService = emailService;
        }

        public void SendNotification(string subject, string message)
        {
            _emailService.SendEmail(subject, message);
        }
    }

}

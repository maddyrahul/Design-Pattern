using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public interface INotification
    {
        void SendNotification(string subject, string message);
    }

}

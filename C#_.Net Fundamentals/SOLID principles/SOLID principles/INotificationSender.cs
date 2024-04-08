using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    public interface INotificationSender
    {
        void SendNotification(string recipient, string message);
    }
}

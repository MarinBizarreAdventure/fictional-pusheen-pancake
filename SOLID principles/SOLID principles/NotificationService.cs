using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class NotificationService
    {
        private readonly List<INotificationSender> _notificationSenders;
        
        public NotificationService()
        {
            _notificationSenders = new List<INotificationSender>();
        }

        public void AddSender(INotificationSender sender)
        {
            _notificationSenders.Add(sender);
        }

        public void SendNotification(string recipient, string message)
        {
            foreach(var sender in _notificationSenders)
            {
                sender.SendNotification(recipient, message);
            }
        }

    }
}

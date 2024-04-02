using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    public class SMSSender : INotificationSender
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS Notification to {recipient}. Message: {message}");
        }
    }
}

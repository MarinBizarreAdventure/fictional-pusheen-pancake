
using SOLID_principles;

class Program
{
    static void Main(string[] args)
    {
        NotificationService notificationService1 = new NotificationService();
        NotificationService notificationService2 = new NotificationService();

        notificationService1.AddSender(new EmailSender());
        notificationService1.AddSender(new SMSSender());
        notificationService1.AddSender(new PushSender());

        notificationService1.AddSender(new EmailSender());
        notificationService1.AddSender(new SMSSender());

        notificationService1.SendNotification("NotService2", "NotService2 send a message");
        notificationService2.SendNotification("NotService1", "NotService2 send a message");

    }
}
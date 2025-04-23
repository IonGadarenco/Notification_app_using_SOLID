namespace SOLID_notification_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User> 
            {
                new User { Id = "1", Email = "ion@gmail.com", Name =  "Ion", Phone = "068857503"},
                new User { Id = "2", Email = "dana@gmail.com", Name = "Dana", Phone = "067543261"},
                new User { Id = "3", Email = "mihai@gmail.com", Name = "Mihai", Phone = "079667788" }
            };

            SmsNotification smsNotification = new SmsNotification();

            NotificationService notificationServiceSms = new NotificationService(smsNotification);
            notificationServiceSms.SendNotification(users, "067543261", "068857503", "Hi, user with Phone = 068857503!");
            notificationServiceSms.SendNotification(users, "068857503", "067543261", "Hi, user with Phone = 067543261!");
            notificationServiceSms.GetMessages();

            EmailNotification emailNotification = new EmailNotification();

            NotificationService notificationServiceEmail = new NotificationService(emailNotification);
            notificationServiceEmail.SendNotification(users, "mihai@gmail.com", "ion@gmail.com", "Hi, user with email = ion@gmail.com!");
            notificationServiceEmail.SendNotification(users, "ion@gmail.com", "dana@gmail.com", "Hi, user with email = dana@gmail.com!");
            notificationServiceEmail.GetMessages();

            PushNotification pushNotification = new PushNotification();

            NotificationService notificationServicePush = new NotificationService(pushNotification);
            notificationServicePush.SendNotification(users, "2", "3", "Hi, user with ID = 3!");
            notificationServicePush.SendNotification(users, "1", "2", "Hi, user with ID = 2!");
            notificationServicePush.GetMessages();
        }
    }
}

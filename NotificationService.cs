using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal class NotificationService
    {
        private ISendNotification _sendNotification;
        private List<Message> _messages = new List<Message>();

        public NotificationService(ISendNotification sendNotification)
        { 
            _sendNotification = sendNotification;
        }

        public void SendNotification(List<User> users, string fromUser, string toUser, string message)
        {
            Message newMessage = _sendNotification.Send(users, fromUser, toUser, message);
            _messages.Add(newMessage);
        }

        public void GetMessages()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine($"From {message.FromUser}, for {message.ToUser}, send message: {message.Text}");
            }
        }
    }
}

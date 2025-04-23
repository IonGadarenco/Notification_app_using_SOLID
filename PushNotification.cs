using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal class PushNotification : ISendNotification
    {
        public Message Send(List<User> users, string fromUser, string toUser, string message)
        {
            foreach (var user in users)
            {
                if (user.Id == toUser)
                    return new Message { FromUser = fromUser, ToUser = toUser, Text = message };
            }
            throw new Exception($"User with ID [{toUser}] don't exist!");
        }
    }
}

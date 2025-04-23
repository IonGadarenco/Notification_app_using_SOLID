using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal class SmsNotification : ISendNotification
    {
        public Message Send(List<User> users, string fromUser, string toUser, string message)
        {
            foreach (var user in users)
            {
                if (user.Phone == toUser)
                    return new Message { FromUser = fromUser, ToUser = toUser, Text = message };
            }

            throw new Exception($"Phone number [{toUser}] don't exist!");
        }
    }
}

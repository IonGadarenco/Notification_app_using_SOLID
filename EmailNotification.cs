using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal class EmailNotification : ISendNotification
    {
        public Message Send(List<User> users, string fromUser, string toUser, string message)
        {
            foreach (var user in users)
            {
                if (user.Email == toUser)
                    return new Message { FromUser = fromUser, ToUser = toUser, Text = message};
            }
            throw new Exception($"User with email [{toUser}] don't exist!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal interface ISendNotification
    {
        Message Send(List<User> users, string fromUser, string toUser, string message);
    }
}

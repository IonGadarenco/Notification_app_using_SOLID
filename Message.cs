using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_notification_app
{
    internal class Message
    {
        public string FromUser {  get; set; }
        public string ToUser { get; set; }
        public string Text { get; set; }
    }
}

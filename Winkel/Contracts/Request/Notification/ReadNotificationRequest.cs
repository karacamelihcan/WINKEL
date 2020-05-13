using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Notification
{
    public class ReadNotificationRequest
    {
        public ReadNotificationRequest(int NotfID)
        {
            this.NotfID = NotfID;
        }
        public int NotfID { get; set; }
    }
}

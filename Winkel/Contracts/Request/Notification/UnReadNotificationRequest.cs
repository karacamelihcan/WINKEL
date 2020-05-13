using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Notification
{
    public class UnReadNotificationRequest
    {
        public UnReadNotificationRequest(int NotfID)
        {
            this.NotfID = NotfID;
        }
        public int NotfID { get; set; }
    }
}

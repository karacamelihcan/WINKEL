using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Notification
{
    public class AddNotificationRequest
    {
        public AddNotificationRequest(int SalesID)
        {
            this.SalesID = SalesID;
        }

        public int SalesID { get; set; }
    }
}

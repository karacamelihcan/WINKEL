using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Notification
{
    public class SellerNotificationRequest
    {
        public SellerNotificationRequest(int SellerID)
        {
            this.SellerID = SellerID;
        }
        public int SellerID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Response.Notification
{
    public  class NotificationListResponse
    {
        public NotificationListResponse()
        {

        }
        public int NotfID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCity { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string ProductUnit { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
        public string Read { get; set; }
    }
}

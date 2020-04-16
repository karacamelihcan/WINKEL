using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Model
{
    public class Notification
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int SalesNumber { get; set; }
        public int Price { get; set; }
        public string IsRead { get; set; }
    }
}

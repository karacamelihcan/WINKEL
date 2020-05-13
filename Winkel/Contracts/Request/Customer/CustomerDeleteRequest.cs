using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Customer
{
    public class CustomerDeleteRequest
    {
        public CustomerDeleteRequest(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        public int CustomerID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Customer
{
    public  class CustomerSearchRequest
    {
        public CustomerSearchRequest(string query)
        {
            this.query = query;
        }
        public string query { get; set; }
    }
}

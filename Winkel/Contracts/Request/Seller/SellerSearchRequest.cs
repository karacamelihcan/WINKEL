using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public  class SellerSearchRequest
    {
        public SellerSearchRequest(string query)
        {
            this.query = query;
        }
        public string query { get; set; }
    }
}

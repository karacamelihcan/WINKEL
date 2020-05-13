using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class SellerProductSearchRequest
    {
        public SellerProductSearchRequest(int SellerID,string query)
        {
            this.SellerID = SellerID;
            this.query = query;
        }
        public int SellerID { get; set; }
        public string query { get; set; }
    }

}

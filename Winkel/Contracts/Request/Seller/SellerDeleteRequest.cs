using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public class SellerDeleteRequest
    {
        public SellerDeleteRequest(int SellerID)
        {
            this.SellerID = SellerID;
        }
        public int SellerID { get; set; }
    }
}

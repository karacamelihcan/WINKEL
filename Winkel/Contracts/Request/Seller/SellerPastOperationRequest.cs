using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public class SellerPastOperationRequest
    {
        public SellerPastOperationRequest(int sellerID)
        {
            this.SellerID = sellerID;
        }
        public int SellerID { get; set; }
    }
}

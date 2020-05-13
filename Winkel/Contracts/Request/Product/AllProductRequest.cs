using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class AllProductRequest
    {
        public AllProductRequest(int SellerID)
        {
            this.SellerID = SellerID;
        }
        public int SellerID { get; set; }
    }
}

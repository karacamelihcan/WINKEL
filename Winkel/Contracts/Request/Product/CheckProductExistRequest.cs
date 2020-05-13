using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class CheckProductExistRequest
    {
        public CheckProductExistRequest(string ProductCode, string ProductName, int Volume, string UnitName, int SellerID)
        {
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
            this.Volume = Volume;
            this.UnitName = UnitName;
            this.SellerID = SellerID;
        }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public int SellerID { get; set; }
    }
}

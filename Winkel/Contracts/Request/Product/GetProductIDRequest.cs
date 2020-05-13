using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class GetProductIDRequest
    {
        public GetProductIDRequest(string CategoryName, string ProductCode, string ProductName, int Volume, string UnitName, string SellerName,string SellerSurname)
        {
            this.CategoryName = CategoryName;
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
            this.Volume = Volume;
            this.UnitName = UnitName;
            this.SellerName = SellerName;
            this.SellerSurname = SellerSurname;
            
        }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
    }
}

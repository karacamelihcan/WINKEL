using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Response.Product
{
    public class SellerProductResponse
    {
        public SellerProductResponse()
        {

        }
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string StockStatus { get; set; }
    }
}

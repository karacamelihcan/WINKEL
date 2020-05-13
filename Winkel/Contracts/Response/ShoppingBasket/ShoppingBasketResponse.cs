using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Response.ShoppingBasket
{
   public class ShoppingBasketResponse
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public string SellerName { get; set; }
        public string SellerSurame { get; set; }
        public string SellerEmail { get; set; }
        public string SellerCity { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
    }
}

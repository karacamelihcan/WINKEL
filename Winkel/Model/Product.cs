using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Category { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string Unit { get; set; }
        public string SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public int StockNumber { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
    }
}

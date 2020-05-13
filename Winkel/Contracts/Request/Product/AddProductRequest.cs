using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class AddProductRequest
    {
        public AddProductRequest(string CategoryName, string ProductCode, string ProductName, int Volume, string UnitName, int SellerID, int StockNumber, decimal Price, string Photo)
        {
            this.CategoryName = CategoryName;
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
            this.Volume = Volume;
            this.UnitName = UnitName;
            this.SellerID = SellerID;
            this.StockNumber = StockNumber;
            this.Price = Price;
            this.Photo = Photo;
        }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public int SellerID { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        
    }
    
}

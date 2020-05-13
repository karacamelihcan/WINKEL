using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class UpdateProductRequest
    {
        public UpdateProductRequest(int ProductID, string CategoryName, string ProductCode, string ProductName, int Volume, string UnitName, int SellerID, int StockNumber,string StockStatus, decimal Price, string Photo)
        {
            this.ProductID = ProductID;
            this.CategoryName = CategoryName;
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
            this.Volume = Volume;
            this.UnitName = UnitName;
            this.SellerID = SellerID;
            this.StockNumber = StockNumber;
            this.StockStatus = StockStatus;
            this.Price = Price;
            this.Photo = Photo;
        }
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public int SellerID { get; set; }
        public int StockNumber { get; set; }
        public string StockStatus { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
}

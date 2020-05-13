using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.ShoppingBasket
{
    public class AddShoppingBasketRequest
    {
        public AddShoppingBasketRequest(int CustomerID,int ProductID,int SalesNumber,decimal Cost)
        {
            this.CustomerID = CustomerID;
            this.ProductID = ProductID;
            this.SalesNumber = SalesNumber;
            this.Cost = Cost;
        }
        public AddShoppingBasketRequest(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
    }
}

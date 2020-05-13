using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Customer
{
    public class CustomerPastOperationRequest
    {
        public CustomerPastOperationRequest(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        public int CustomerID { get; set; }
        public int SalesID { get; internal set; }
        public string SellerName { get; internal set; }
        public string SellerSurname { get; internal set; }
        public string SellerEmail { get; internal set; }
        public string ProductCategory { get; internal set; }
        public string ProductCode { get; internal set; }
        public string ProductName { get; internal set; }
        public int Volume { get; internal set; }
        public string Unit { get; internal set; }
        public int SalesNumber { get; internal set; }
        public decimal Cost { get; internal set; }
        public string Photo { get; internal set; }
        public string SellerCity { get; internal set; }
    }
}

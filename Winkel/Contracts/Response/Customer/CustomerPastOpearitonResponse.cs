using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Response.Customer
{
    public class CustomerPastOpearitonResponse
    {
        public CustomerPastOpearitonResponse()
        {

        }
        public int SalesID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string SellerEmail { get; set; }
        public string SellerCity { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public string Unit { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
        public string Photo { get; set; }
    }
}

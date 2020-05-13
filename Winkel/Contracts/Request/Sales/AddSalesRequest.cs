using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Sales
{
    public class AddSalesRequest
    {
        public AddSalesRequest(int CustomerID, string SellerName, string SellerSurname,string SellerEmail,int ProductID,int SalesNumber,decimal Cost)
        {
            this.CustomerID = CustomerID;
            this.SellerName = SellerName;
            this.SellerSurname = SellerSurname;
            this.SellerEmail = SellerEmail;
            this.ProductID = ProductID;
            this.SalesNumber = SalesNumber;
            this.Cost = Cost;
        }
        public AddSalesRequest()
        {

        }
        public int CustomerID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string SellerEmail { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }

    }
}

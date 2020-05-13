using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class CalculateCostRequest
    {
        public CalculateCostRequest(int ProductID,int SalesNumber)
        {
            this.ProductID = ProductID;
            this.SalesNumber = SalesNumber;
        }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
    }
}

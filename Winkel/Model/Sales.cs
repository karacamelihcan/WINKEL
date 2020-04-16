using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Model
    {

    public class Sales
    {
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public int Cost { get; set; }
        public int SalesID { get; set; }
        public string Category { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductVolume { get; set; }
        public string ProductUnit { get; set; }
    }
}

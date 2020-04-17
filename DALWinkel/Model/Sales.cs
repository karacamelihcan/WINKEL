using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALWinkel.Model
{
    [Table("TBLSALES")]
    public class Sales
    {
        public int SalesID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }

    }
}

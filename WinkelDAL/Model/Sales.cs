using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("Sales")]
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }
        public int SellerID { get; set; } 
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
    }
}

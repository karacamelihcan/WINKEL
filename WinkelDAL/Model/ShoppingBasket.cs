using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("ShoppingBasket")]
    public class ShoppingBasket
    {
        [Key]
        public int ShoppingBasketID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int SalesNumber { get; set; }
        public decimal Cost { get; set; }
    }
}




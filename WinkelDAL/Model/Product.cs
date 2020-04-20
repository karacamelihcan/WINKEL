using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
        public int UnitID { get; set; }
        public int SellerID { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public bool StockID { get; set; }
        public bool StatusID { get; set; }
    }
}

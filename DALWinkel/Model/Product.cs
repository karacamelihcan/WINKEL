using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALWinkel.Model
{
    [Table("TBLPRODUCT")]
    public class Product
    {
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public string UnitName { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string Status { get; set; }
        public string StockStatus { get; set; }


    }

}

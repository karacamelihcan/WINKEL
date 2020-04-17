using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALWinkel.Model
{
    [Table("CATEGORY")]
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

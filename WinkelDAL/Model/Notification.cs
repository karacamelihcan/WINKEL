using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("Notification")]
    public class Notification
    {
        [Key]
        public int NotfID { get; set; }
        public int SalesID { get; set; }
        public bool ReadID { get; set; } = false;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public bool StatusID { get; set; }
        public string StatusName { get; set; }
    }
}

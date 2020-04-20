using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinkelDAL.Model
{
    [Table("ReadStatus")]
    public class ReadStatus
    {
        [Key]
        public bool ReadID { get; set; }
        public string ReadName { get; set; }
    }
}

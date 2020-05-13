using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Unit
{
    public class UnitIDRequest
    {
        public UnitIDRequest(string UnitName)
        {
            this.UnitName = UnitName;
        }
        public string UnitName { get; set; }
    }
}

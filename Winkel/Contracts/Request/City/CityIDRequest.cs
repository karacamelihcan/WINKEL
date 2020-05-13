using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.City
{
    public class CityIDRequest
    {
        public CityIDRequest(string CityName)
        {
            this.CityName = CityName;
        }
        public string CityName { get; set; }
    }
}

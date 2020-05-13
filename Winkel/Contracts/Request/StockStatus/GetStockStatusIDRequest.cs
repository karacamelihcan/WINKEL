using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.StockStatus
{
    public class GetStockStatusIDRequest
    {
        public GetStockStatusIDRequest(string StockStatus)
        {
            this.StockStatus = StockStatus;
        }
        public string StockStatus { get; set; }
    }
}

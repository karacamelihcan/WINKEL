using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.StockStatus;
using Winkel.Contracts.Response.StockStatus;
using Winkel.Contracts.Response.Unit;

namespace Winkel.Services.StockStatusServices
{
    public interface IStockStatusService
    {
        bool GetStockStatusID(GetStockStatusIDRequest statusIDRequest);
        List<ListStockStatus> StockStatusList();
    }
}

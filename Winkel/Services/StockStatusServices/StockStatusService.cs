using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.StockStatus;
using Winkel.Contracts.Response.StockStatus;
using Winkel.Contracts.Response.Unit;
using Winkel.Services.StockStatusServices;
using WinkelDAL.Context;

namespace Winkel.Services.StockServices
{
    public class StockStatusService : IStockStatusService
    {
        
        public bool GetStockStatusID(GetStockStatusIDRequest statusIDRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                return dataAccess.StockStatus.Where(x => x.StockStatu == statusIDRequest.StockStatus).Select(x => x.StockID).ToArray()[0];
            }
        }

        public List<ListStockStatus> StockStatusList()
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var statuList = dataAccess.StockStatus.Select(X => new ListStockStatus
                {
                    StockStatus = X.StockStatu
                });
                return statuList.ToList();
            }
        }
    }
}

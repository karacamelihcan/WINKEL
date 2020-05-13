using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;
using WinkelDAL.Context;
using Winkel.Contracts.Request.Unit;
using Winkel.Contracts.Response.Unit;

namespace Winkel.Services.UnitServices
{
    public class UnitService : IUnitService
    {
        public List<UnitListResponse> UnitList()
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var citylist = dataAccess.Unit.Select(X => new UnitListResponse
                {
                    UnitName = X.UnitName
                });
                return citylist.ToList();
                
            }
        }

        public int GetUnitID(UnitIDRequest unitIDRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                return dataAccess.Unit.Where(x => x.UnitName == unitIDRequest.UnitName).Select(x => x.UnitID).ToArray()[0];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Unit;
using Winkel.Contracts.Response.Unit;


namespace Winkel.Services.UnitServices
{
    public interface IUnitService
    {
        List<UnitListResponse> UnitList();
        int GetUnitID(UnitIDRequest unitIDRequest);
    }
}

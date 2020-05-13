using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.City;
using Winkel.Contracts.Response.City;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public interface ICityService
    {
        List<CityListResponse> CityList();
        int GetCityID(CityIDRequest cityIDRequest);
    }
}

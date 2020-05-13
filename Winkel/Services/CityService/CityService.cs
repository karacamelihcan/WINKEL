using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;
using WinkelDAL.Context;
using Winkel.Contracts.Request.City;
using Winkel.Contracts.Response.City;

namespace Winkel.Services
{
    public class CityService : ICityService
    {
        public List<CityListResponse> CityList()
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var citylist = dataAccess.Cities.Select(X => new CityListResponse
                {
                    CityName = X.CityName
                });
                return citylist.ToList();
                
            }
        }

        public int GetCityID(CityIDRequest cityIDRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                return dataAccess.Cities.Where(x => x.CityName == cityIDRequest.CityName).Select(x => x.CityID).ToArray()[0];
            }
        }
    }
}

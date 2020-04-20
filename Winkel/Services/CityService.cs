using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;
using WinkelDAL.Context;

namespace Winkel.Services
{
    public class CityService : ICityService
    {
        public List<City> CityList()
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                return dataAccess.Cities.ToList();
            }
        }

        public int GetCityID(string cityName)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                return dataAccess.Cities.Where(x => x.CityName == cityName).Select(x => x.CityID).ToArray()[0];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public interface ICityService
    {
        List<City> CityList();
        int GetCityID(string cityName);
    }
}

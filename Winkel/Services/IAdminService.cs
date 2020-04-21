using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public interface IAdminService
    {
        bool LogIn(Admin admin);
        int Register(Admin admin);
    }
}

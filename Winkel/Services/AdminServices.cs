using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public class AdminServices : IAdminService
    {
        public AdminServices()
        {

        }
        public bool LogIn(Admin admin)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                if (dataAccess.Admins.Where(x => x.Email == admin.Email && x.Password == admin.Password).Count() > 0)
                {
                    var adminlogin = dataAccess.Admins.Where(x => x.Email == admin.Email && x.Password == admin.Password).FirstOrDefault<Admin>();

                    if (String.Compare(adminlogin.Email, admin.Email, false) == 0 && String.Compare(adminlogin.Password, admin.Password, false) == 0)
                        return true;
                    else
                        return false;

                }
                else
                    return false;
                
            }
        }

        public int Register(Admin admin)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                dataAccess.Admins.Add(admin);
                return dataAccess.SaveChanges();
            }
        }
    }
}

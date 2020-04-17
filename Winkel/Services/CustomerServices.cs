using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALWinkel.Context;
using DALWinkel.Model;

namespace Winkel.Services
{
    public class CustomerServices
    {
        public static List<Customer> CustomerList()
        {
            using(WinkelEntities winkelEntities = new WinkelEntities())
            {
                List<Customer> customers = winkelEntities.LISTCUSTOMER().Select(x => new Customer()
                {
                    CustomerID = x.MÜŞTERİ_ID,
                    Name = x.MÜŞTERİ_ADI,
                    Surname = x.MÜŞTERİ_SOYADI,
                    Email = x.EMAIL,
                    Password = x.ŞİFRE,
                    City = x.ŞEHİR,
                    Photo = x.FOTOĞRAF
                }).ToList();
                return customers;
            }
        }
        
    }
}

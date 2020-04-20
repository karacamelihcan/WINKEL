using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Context;
using WinkelDAL.Model;
using WinkelDAL.InnerJoin;

namespace Winkel.Services
{
    public class CustomerService:ICustomerService
    {
        
        public CustomerService()
        {
            
        }

        public List<CustomerInnerJoin> GetCustomer()
        {
            using(DataAccess dataAccess = new DataAccess())
            {
                var CustomerList = from customer in dataAccess.Customers
                                   where (customer.StatusID == true)
                                   join city in dataAccess.Cities
                                   on customer.CityID equals city.CityID
                                   select new CustomerInnerJoin
                                   {
                                       CustomerID = customer.CustomerID,
                                       Name = customer.Name,
                                       Surname = customer.Surname,
                                       Email = customer.Email,
                                       Password=customer.Password,
                                       CityName = city.CityName.ToUpper(),
                                       Photo = customer.Photo
                                   };

                return CustomerList.ToList();
                                 
            }
            
        }

        public bool LogIn(Customer customer)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var value = dataAccess.Customers.Where(x => x.Email == customer.Email && x.Password == customer.Password && x.StatusID == true)
                                                .Count();
                if (value > 0)
                    return true;
                else
                    return false;
            }
        }

        public int Register(Customer customer)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                dataAccess.Customers.Add(customer);
                return dataAccess.SaveChanges();
            }
        }
    }
}

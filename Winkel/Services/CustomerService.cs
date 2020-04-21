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

                if (dataAccess.Customers.Where(x => x.Email == customer.Email && x.Password == customer.Password && x.StatusID == true).Count() > 0)
                {
                    var customerlogin = dataAccess.Customers.Where(x => x.Email == customer.Email && x.Password == customer.Password).FirstOrDefault<Customer>();

                    if (String.Compare(customer.Email, customerlogin.Email, false) == 0 && String.Compare(customer.Password, customerlogin.Password, false) == 0)
                        return true;
                    else
                        return false;

                }
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
        
        public bool Delete(Customer customer)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var customerdeleted = dataAccess.Customers.Where(x => x.CustomerID == customer.CustomerID)
                                                        .FirstOrDefault<Customer>();
                customerdeleted.StatusID = false;
                dataAccess.Update(customerdeleted);
                return dataAccess.SaveChanges() > 0;
            }
        }
        public bool Update(Customer customer)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var customerUpdated = dataAccess.Customers.Where(x => x.CustomerID == customer.CustomerID)
                                                        .FirstOrDefault<Customer>();
                customerUpdated.Name = customer.Name;
                customerUpdated.Surname = customer.Surname;
                customerUpdated.Email = customer.Email;
                customerUpdated.Password = customer.Password;
                customerUpdated.CityID = customer.CityID;
                customerUpdated.Photo = customer.Photo;
                dataAccess.Update(customerUpdated);
                return dataAccess.SaveChanges()>0;
            }
        }

        public List<CustomerInnerJoin> SearchCustomer(string query)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                
                var CustomerList = from customer in dataAccess.Customers
                                   where (customer.StatusID == true &&(customer.Name.StartsWith(query)||customer.Surname.StartsWith(query)|| (customer.Name + " " + customer.Surname).StartsWith(query)))
                                   join city in dataAccess.Cities
                                   on customer.CityID equals city.CityID
                                   select new CustomerInnerJoin
                                   {
                                       CustomerID = customer.CustomerID,
                                       Name = customer.Name,
                                       Surname = customer.Surname,
                                       Email = customer.Email,
                                       Password = customer.Password,
                                       CityName = city.CityName.ToUpper(),
                                       Photo = customer.Photo
                                   };
                return CustomerList.ToList();
            }
        }

        public List<SalesListCustomer> PastOperations(Customer customer)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var cust = dataAccess.Customers.FirstOrDefault(x => x.CityID == customer.CustomerID);
                var pastOperation = from sales in dataAccess.Sales
                                    where (sales.CustomerID == customer.CustomerID)
                                    join seller in dataAccess.Sellers on sales.SellerID equals seller.SellerID
                                    join city in dataAccess.Cities on seller.CityID equals city.CityID
                                    join product in dataAccess.Products on sales.ProductID equals product.ProductID
                                    join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                                    join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                                    select new SalesListCustomer
                                    {
                                        SalesID = sales.SalesID,
                                        SellerName = seller.Name,
                                        SellerSurname = seller.Surname,
                                        SellerEmail = seller.Email,
                                        SellerCity = city.CityName,
                                        ProductCategory = category.CategoryName,
                                        ProductCode = product.ProductCode,
                                        ProductName = product.ProductName,
                                        Volume = product.Volume,
                                        Unit = unit.UnitName,
                                        SalesNumber = sales.SalesNumber,
                                        Cost = sales.Cost,
                                        Photo = product.Photo
                                    };
                return pastOperation.OrderByDescending(x=>x.SalesID).ToList();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Context;
using WinkelDAL.Model;
using Winkel.Contracts.Response.Customer;
using Winkel.Contracts.Request.Customer;
using Winkel.Contracts.Request.City;
using Winkel.Contracts.Response.City;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Winkel.Contracts.Request.Sales;
using Winkel.Contracts.Request.ShoppingBasket;
using Winkel.Services.ShoppingBasketServices;
using Winkel.Contracts.Response.ShoppingBasket;

namespace Winkel.Services
{
    public class CustomerService : ICustomerService
    {

        public CustomerService()
        {

        }

        readonly CityService cityService = new CityService();
        private IShoppingBasketService shoppingBasketService = new ShoppingBasketService();

        public List<CustomerListResponse> GetCustomer()
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var CustomerList = from customer in dataAccess.Customers
                                   where (customer.StatusID == true)
                                   join city in dataAccess.Cities
                                   on customer.CityID equals city.CityID
                                   select new CustomerListResponse
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

        public bool LogIn(CustomerLogInRequest logInRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {

                if (dataAccess.Customers.Where(x => x.Email == logInRequest.Email && x.Password == logInRequest.Password && x.StatusID == true).Count() > 0)
                {
                    var customerlogin = dataAccess.Customers.Where(x => x.Email == logInRequest.Email && x.Password == logInRequest.Password).FirstOrDefault<Customer>();

                    if (String.Compare(logInRequest.Email, customerlogin.Email, false) == 0 && String.Compare(logInRequest.Password, customerlogin.Password, false) == 0)
                        return true;
                    else
                        return false;

                }
                else
                    return false;
            }
        }

        public int Register(CustomerRegisterRequest registerRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                Customer customer = new Customer();
                customer.Name = registerRequest.Name;
                customer.Surname = registerRequest.Surname;
                customer.Email = registerRequest.Email;
                customer.Password = registerRequest.Password;
                customer.CityID = GetCityID(new CityIDRequest(registerRequest.CityName));
                customer.Photo = registerRequest.Photo;
                dataAccess.Customers.Add(customer);
                return dataAccess.SaveChanges();
            }
        }

        public bool Delete(CustomerDeleteRequest deleteRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var customerdeleted = dataAccess.Customers.Where(x => x.CustomerID == deleteRequest.CustomerID)
                                                        .FirstOrDefault<Customer>();
                customerdeleted.StatusID = false;
                dataAccess.Update(customerdeleted);
                return dataAccess.SaveChanges() > 0;
            }
        }
        public bool Update(CustomerUpdateRequest updateRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var customerUpdated = dataAccess.Customers.Where(x => x.CustomerID == updateRequest.CustomerID)
                                                        .FirstOrDefault<Customer>();
                customerUpdated.Name = updateRequest.Name;
                customerUpdated.Surname = updateRequest.Surname;
                customerUpdated.Email = updateRequest.Email;
                customerUpdated.Password = updateRequest.Password;
                customerUpdated.CityID = GetCityID(new CityIDRequest(updateRequest.CityName));
                customerUpdated.Photo = updateRequest.Photo;
                dataAccess.Update(customerUpdated);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public List<CustomerListResponse> SearchCustomer(CustomerSearchRequest searchRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {

                var CustomerList = from customer in dataAccess.Customers
                                   where (customer.StatusID == true && (customer.Name.StartsWith(searchRequest.query) || customer.Surname.StartsWith(searchRequest.query) || (customer.Name + " " + customer.Surname).StartsWith(searchRequest.query)))
                                   join city in dataAccess.Cities
                                   on customer.CityID equals city.CityID
                                   select new CustomerListResponse
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

        public List<CustomerPastOpearitonResponse> PastOperations(CustomerPastOperationRequest pastOperationRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var cust = dataAccess.Customers.FirstOrDefault(x => x.CustomerID == pastOperationRequest.CustomerID);
                var pastOperation = from sales in dataAccess.Sales
                                    where (sales.CustomerID == pastOperationRequest.CustomerID)
                                    join seller in dataAccess.Sellers on sales.SellerID equals seller.SellerID
                                    join city in dataAccess.Cities on seller.CityID equals city.CityID
                                    join product in dataAccess.Products on sales.ProductID equals product.ProductID
                                    join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                                    join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                                    select new Winkel.Contracts.Response.Customer.CustomerPastOpearitonResponse
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
                return pastOperation.OrderByDescending(x => x.SalesID).ToList();
            }
        }

        public bool CheckEmail(CustomerCheckEmailRequest checkEmailRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                return dataAccess.Customers.Where(x => x.Email == checkEmailRequest.Email && x.StatusID == true).Count() < 1;
            }
        }

        public List<CityListResponse> CityList()
        {
            return cityService.CityList();
        }

        public int GetCityID(CityIDRequest cityIDRequest)
        {
            return cityService.GetCityID(cityIDRequest);
        }

        public bool ForgotPassword(ForgotPasswordRequest forgotPassword)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var customer = dataAccess.Customers.Where(x => x.Email == forgotPassword.Email).FirstOrDefault<Customer>();

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("noreply.winkel@gmail.com", "winkel123");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("noreply.winkel@gmail.com", "Winkel Industry");
                mail.To.Add(forgotPassword.Email);
                mail.Subject = "Your Password";
                mail.IsBodyHtml = true;

                mail.Body = "Dear " + customer.Name + " " + customer.Surname + ";" + Environment.NewLine + " Your password is " + customer.Password; ;
                try
                {
                    smtp.Send(mail);
                    return true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public string GetCustomerNameSurname(GetCustomerNameSurname customer)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var newcust = dataAccess.Customers.Where(x => x.Email == customer.Email && x.Password == customer.Password).FirstOrDefault<Customer>();
                return (newcust.Name + " " + newcust.Surname);
            }
        }

        public CustomerInfoResponse GetCustomerInfo(GetCustomerID getCustomerID)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var customer = from cust in dataAccess.Customers
                                 where (cust.StatusID == true && cust.Email == getCustomerID.Email && cust.Password == getCustomerID.Password)
                                 join city in dataAccess.Cities
                                 on cust.CityID equals city.CityID
                                 select new CustomerInfoResponse
                                 {
                                     CustomerID = cust.CustomerID,
                                     Name = cust.Name,
                                     Surname = cust.Surname,
                                     Email = cust.Email,
                                     Password = cust.Password,
                                     CityName = city.CityName.ToUpper(),
                                     Photo = cust.Photo
                                 };
                return customer.ToList()[0];
            }
        }

        public int AddSales(AddShoppingBasketRequest addShoppingBasketRequest)
        {
            return shoppingBasketService.AddSales(addShoppingBasketRequest);
        }

        public bool ClearShoppingBasket(ClearShoppingListRequest clearShoppingList)
        {
            return shoppingBasketService.ClearShoppingBasket(clearShoppingList);
        }

        public int AddShoppingList(AddShoppingBasketRequest addShoppingBasket)
        {
            return shoppingBasketService.AddShoppingList(addShoppingBasket);
        }

        public List<ShoppingBasketResponse> ShoppingList(ShoppingListRequest shoppingListRequest)
        {
            return shoppingBasketService.ShoppingList(shoppingListRequest);
        }

        public bool ClearAllShoppingList(ClearAllShoppingList clearAllShoppingList)
        {
            return shoppingBasketService.ClearAllShoppingList(clearAllShoppingList);
        }
    }
}

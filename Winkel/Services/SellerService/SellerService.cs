using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Category;
using Winkel.Contracts.Request.City;
using Winkel.Contracts.Request.Notification;
using Winkel.Contracts.Request.Product;
using Winkel.Contracts.Request.Seller;
using Winkel.Contracts.Response.Category;
using Winkel.Contracts.Response.City;
using Winkel.Contracts.Response.Notification;
using Winkel.Contracts.Response.Product;
using Winkel.Contracts.Response.Seller;
using Winkel.Contracts.Response.StockStatus;
using Winkel.Contracts.Response.Unit;
using Winkel.Services.ProductServices;
using WinkelDAL.Context;
using WinkelDAL.Model;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Winkel.Services
{
    public class SellerService : ISellerService
    {
        readonly ICityService cityService = new CityService();
        readonly INotificationService notificationService = new NotificationService();
        readonly IProductService productService = new ProductService();

        public List<ActiveProductListResponse> ActiveProductList()
        {
            return productService.ActiveProductList();
        }

        public int AddCategory(AddCategoryRequest addCategoryRequest)
        {
            return productService.AddCategory(addCategoryRequest);
        }

        public int AddProduct(AddProductRequest addProduct)
        {
            return productService.AddProduct(addProduct);
        }

        public List<SellerProductResponse> AllProductList(AllProductRequest allProduct)
        {
            return productService.AllProductList(allProduct);
        }

        public List<CategoryListResponse> CategoryList()
        {
            return productService.CategoryList();
        }

        public bool CheckCategoryName(CheckCategoryName checkCategory)
        {
            return productService.CheckCategoryName(checkCategory);
        }

        public bool CheckEmail(SellerCheckEmailRequest checkEmail)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                return dataAccess.Sellers.Where(x => x.Email == checkEmail.Email &&x.StatusID==true).Count() <1;
            }
        }

        public bool CheckProductExist(CheckProductExistRequest checkProductExist)
        {
            return productService.CheckProductExist(checkProductExist);
        }

        public List<CityListResponse> CityList()
        {
            return cityService.CityList();
        }

        public bool Delete(SellerDeleteRequest deleteRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                if (dataAccess.Sellers.Where(x => x.SellerID == deleteRequest.SellerID && x.StatusID == true).Count() > 0 )
                {
                    var sellerdeleted = dataAccess.Sellers.Where(x => x.SellerID == deleteRequest.SellerID && x.StatusID == true)
                                                          .FirstOrDefault<Seller>();
                    sellerdeleted.StatusID = false;
                    dataAccess.Update(sellerdeleted);
                    DeleteASellerAllProduct(deleteRequest);
                    return dataAccess.SaveChanges() > 0;
                }
                else
                    return false;
            }
        }

        public int DeleteASellerAllProduct(SellerDeleteRequest deleteRequest)
        {
            return productService.DeleteASellerAllProduct(new DeleteASellerAllProductRequest(deleteRequest.SellerID));
        }

        public bool DeleteProduct(DeleteProductRequest deleteProduct)
        {
            return productService.DeleteProduct(deleteProduct);
        }

        public bool ForgotPassword(ForgotPasswordRequest forgotPassword)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var seller = dataAccess.Sellers.Where(x => x.Email == forgotPassword.Email).FirstOrDefault<Seller>();
                
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
                
                mail.Body = "Dear " + seller.Name + " " + seller.Surname + ";"+ Environment.NewLine +" Your password is " + seller.Password; ;
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
        

        public int GetCityID(CityIDRequest cityIDRequest)
        {
            return cityService.GetCityID(cityIDRequest);
        }

        public List<SellerListResponse> GetSeller()
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var sellers = from seller in dataAccess.Sellers
                              where (seller.StatusID == true)
                              join city in dataAccess.Cities
                              on seller.CityID equals city.CityID
                              select new SellerListResponse
                              {
                                       SellerID = seller.SellerID,
                                       Name = seller.Name,
                                       Surname = seller.Surname,
                                       Email = seller.Email,
                                       Password = seller.Password,
                                       CityName = city.CityName.ToUpper(),
                                       Photo = seller.Photo
                              };

                return sellers.ToList();

            }
        }

        public int GetSellerID(GetSellerID getSellerID)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var seller = dataAccess.Sellers.Where(x => x.Email == getSellerID.Email && x.Name == getSellerID.SellerName && x.Surname == getSellerID.SellerSurname).FirstOrDefault<Seller>();
                return seller.SellerID;
            }
        }

        public string GetSellerNameSurname(GetSellerNameSurname seller)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var newseller = dataAccess.Sellers.Where(x => x.Email == seller.Email && x.Password == seller.Password).FirstOrDefault<Seller>();
                return (newseller.Name + " " + newseller.Surname);
            }
        }

        public bool LogIn(SellerLogInRequest sellerLogInRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {

                if (dataAccess.Sellers.Where(x => x.Email == sellerLogInRequest.Email && x.Password == sellerLogInRequest.Password && x.StatusID == true).Count() > 0)
                {
                    var sellerlogin = dataAccess.Sellers.Where(x => x.Email == sellerLogInRequest.Email && x.Password == sellerLogInRequest.Password).FirstOrDefault<Seller>();

                    if (String.Compare(sellerLogInRequest.Email, sellerlogin.Email, false) == 0 && String.Compare(sellerLogInRequest.Password, sellerlogin.Password, false) == 0)
                        return true;
                    else
                        return false;

                }
                else
                    return false;
            }
        }

        public List<NotificationListResponse> NotificationList(SellerNotificationRequest notificationRequest)
        {
            return notificationService.NotificationList(notificationRequest);
        }

        public List<SellerPastOpearitonResponse> PastOperations(SellerPastOperationRequest pastOperations)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var pastOperation = from sales in dataAccess.Sales
                                    where (sales.SellerID == pastOperations.SellerID)
                                    join customer in dataAccess.Customers on sales.CustomerID equals customer.CustomerID
                                    join city in dataAccess.Cities on customer.CityID equals city.CityID
                                    join product in dataAccess.Products on sales.ProductID equals product.ProductID
                                    join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                                    join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                                    select new SellerPastOpearitonResponse
                                    {
                                        SalesID = sales.SalesID,
                                        CustomerName = customer.Name,
                                        CustomerSurname = customer.Surname,
                                        CustomerEmail = customer.Email,
                                        CustomerCity = city.CityName,
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

        public bool ReadNotification(ReadNotificationRequest readNotification)
        {
            return notificationService.ReadNotification(readNotification);
        }

        public int Register(SellerRegisterRequest registerRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                Seller seller = new Seller();
                seller.Name = registerRequest.Name.ToUpper();
                seller.Surname = registerRequest.Surname.ToUpper();
                seller.Email = registerRequest.Email;
                seller.Password = registerRequest.Password;

                seller.CityID = GetCityID(new CityIDRequest(registerRequest.CityName));
                seller.Photo = registerRequest.Photo;
                dataAccess.Sellers.Add(seller);
                return dataAccess.SaveChanges();
            }
        }

        public List<ActiveProductListResponse> SearchProduct(SearchProductRequest searchProductRequest)
        {
            return productService.SearchProduct(searchProductRequest);
        }

        public List<SellerListResponse> SearchSeller(SellerSearchRequest searchRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {

                var SellerList = from seller in dataAccess.Sellers
                                   where (seller.StatusID == true && (seller.Name.StartsWith(searchRequest.query) || seller.Surname.StartsWith(searchRequest.query) || (seller.Name + " " + seller.Surname).StartsWith(searchRequest.query)))
                                   join city in dataAccess.Cities
                                   on seller.CityID equals city.CityID
                                   select new SellerListResponse
                                   {
                                       SellerID = seller.SellerID,
                                       Name = seller.Name,
                                       Surname = seller.Surname,
                                       Email = seller.Email,
                                       Password = seller.Password,
                                       CityName = city.CityName.ToUpper(),
                                       Photo = seller.Photo
                                   };
                return SellerList.ToList();
            }
        }

        public List<ListStockStatus> StockStatusList()
        {
            return productService.StockStatusList();
        }

        public List<UnitListResponse> UnitList()
        {
            return productService.UnitList();
        }

        public bool UnReadNotification(UnReadNotificationRequest unreadNotification)
        {
            return notificationService.UnReadNotification(unreadNotification);
        }

        public bool Update(SellerUpdateRequest updateRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var SellerUpdated = dataAccess.Sellers.Where(x => x.SellerID == updateRequest.SellerID)
                                                        .FirstOrDefault<Seller>();
                SellerUpdated.Name = updateRequest.Name;
                SellerUpdated.Surname = updateRequest.Surname;
                SellerUpdated.Email = updateRequest.Email;
                SellerUpdated.Password = updateRequest.Password;
                SellerUpdated.CityID = GetCityID(new CityIDRequest(updateRequest.CityName));
                SellerUpdated.Photo = updateRequest.Photo;
                dataAccess.Update(SellerUpdated);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public bool UpdateProduct(UpdateProductRequest updateProduct)
        {
            return productService.UpdateProduct(updateProduct);
        }

        public SellerInformationResponse GetSellerInfo(GetSellerID getSellerID)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var SellerList = from seller in dataAccess.Sellers
                                   where (seller.StatusID == true && seller.Email==getSellerID.Email && seller.Password==getSellerID.Password)
                                   join city in dataAccess.Cities
                                   on seller.CityID equals city.CityID
                                   select new SellerInformationResponse
                                   {
                                       SellerID = seller.SellerID,
                                       Name = seller.Name,
                                       Surname = seller.Surname,
                                       Email = seller.Email,
                                       Password = seller.Password,
                                       CityName = city.CityName.ToUpper(),
                                       Photo = seller.Photo
                                   };
                return SellerList.ToList()[0];
            }
        }

        public List<SellerProductResponse> SellerProductSearch(SellerProductSearchRequest searchProductRequest)
        {
            return productService.SellerProductSearch(searchProductRequest);
        }
    }
}

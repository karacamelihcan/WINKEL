using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;
using Winkel.Contracts.Response.Customer;
using Winkel.Contracts.Request.Customer;
using Winkel.Contracts.Response.City;
using Winkel.Contracts.Request.City;

using Winkel.Contracts.Request.ShoppingBasket;
using Winkel.Contracts.Response.ShoppingBasket;

namespace Winkel.Services
{
    public interface ICustomerService
    {
        List<CustomerListResponse> GetCustomer();
        bool LogIn(CustomerLogInRequest logInRequest);
        int Register(CustomerRegisterRequest registerRequest);
        bool Delete(CustomerDeleteRequest deleteRequest);
        bool Update(CustomerUpdateRequest updateRequest);
        List<CustomerListResponse> SearchCustomer(CustomerSearchRequest searchRequest);
        List<CustomerPastOpearitonResponse> PastOperations(CustomerPastOperationRequest pastOperationRequest);
        bool CheckEmail(CustomerCheckEmailRequest checkEmailRequest);
        List<CityListResponse> CityList();
        int GetCityID(CityIDRequest cityIDRequest);
        bool ForgotPassword(ForgotPasswordRequest forgotPassword);
        string GetCustomerNameSurname(GetCustomerNameSurname customer);
        CustomerInfoResponse GetCustomerInfo(GetCustomerID getCustomerID);
        int AddSales(AddShoppingBasketRequest addShoppingBasketRequest);
        bool ClearShoppingBasket(ClearShoppingListRequest clearShoppingList);
        int AddShoppingList(AddShoppingBasketRequest addShoppingBasket);
        List<ShoppingBasketResponse> ShoppingList(ShoppingListRequest shoppingListRequest);
        bool ClearAllShoppingList(ClearAllShoppingList clearAllShoppingList);


    }
}

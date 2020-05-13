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

namespace Winkel.Services
{
    public interface ISellerService
    {
        //Seller
        List<SellerListResponse> GetSeller();
        bool LogIn(SellerLogInRequest sellerLogInRequest);
        int Register(SellerRegisterRequest registerRequest);
        bool Delete(SellerDeleteRequest deleteRequest);
        int DeleteASellerAllProduct(SellerDeleteRequest deleteRequest);
        bool Update(SellerUpdateRequest updateRequest);
        List<SellerListResponse> SearchSeller(SellerSearchRequest searchRequest);
        List<SellerPastOpearitonResponse> PastOperations(SellerPastOperationRequest pastoperations);
        bool CheckEmail(SellerCheckEmailRequest checkEmail);
        List<NotificationListResponse> NotificationList(SellerNotificationRequest notificationRequest);
        bool ReadNotification(ReadNotificationRequest readNotification);
        bool UnReadNotification(UnReadNotificationRequest unreadNotification);
        List<CityListResponse> CityList();
        int GetCityID(CityIDRequest cityIDRequest);
        bool ForgotPassword(ForgotPasswordRequest forgotPassword);
        string GetSellerNameSurname(GetSellerNameSurname seller);
        SellerInformationResponse GetSellerInfo(GetSellerID getSellerID);
        int GetSellerID(GetSellerID getSellerID);

        //PRODUCT
        int AddProduct(AddProductRequest addProduct);
        bool CheckProductExist(CheckProductExistRequest checkProductExist);
        bool DeleteProduct(DeleteProductRequest deleteProduct);
        bool UpdateProduct(UpdateProductRequest updateProduct);
        List<ActiveProductListResponse> ActiveProductList();
        List<SellerProductResponse> AllProductList(AllProductRequest allProduct);
        List<ActiveProductListResponse> SearchProduct(SearchProductRequest searchProductRequest);
        List<CategoryListResponse> CategoryList();
        int AddCategory(AddCategoryRequest addCategoryRequest);
        bool CheckCategoryName(CheckCategoryName checkCategory);
        List<UnitListResponse> UnitList();
        List<ListStockStatus> StockStatusList();
        List<SellerProductResponse> SellerProductSearch(SellerProductSearchRequest searchProductRequest);

    }
}

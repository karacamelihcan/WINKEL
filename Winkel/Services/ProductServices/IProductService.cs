using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Category;
using Winkel.Contracts.Request.Product;
using Winkel.Contracts.Request.StockStatus;
using Winkel.Contracts.Request.Unit;
using Winkel.Contracts.Response.Category;
using Winkel.Contracts.Response.Product;
using Winkel.Contracts.Response.StockStatus;
using Winkel.Contracts.Response.Unit;

namespace Winkel.Services.ProductServices
{
    public interface IProductService
    {
        #region Product Operations
        int AddProduct(AddProductRequest addProduct);
        decimal CalculateCost(CalculateCostRequest costRequest);
        bool CheckProductExist(CheckProductExistRequest checkProductExist);
        bool CheckStatus(CheckStatusRequest checkStatus);
        int DeleteASellerAllProduct(DeleteASellerAllProductRequest deleteASellerAllProduct);
        bool DeleteProduct(DeleteProductRequest deleteProduct);
        List<int> stockNumberRequest(StockNumberRequest stockNumberRequest);
        bool UpdateProduct(UpdateProductRequest updateProduct);
        bool UpdateStockNumber(UpdateStockNumberRequest updateStockNumber);
        List<ActiveProductListResponse> ActiveProductList();
        List<SellerProductResponse> AllProductList(AllProductRequest allProduct);
        List<ActiveProductListResponse> SearchProduct(SearchProductRequest searchProductRequest);
        List<SellerProductResponse> SellerProductSearch(SellerProductSearchRequest searchProductRequest);
        int GetProductID(GetProductIDRequest getProductID);

        #endregion

        #region Category Opeations
        List<CategoryListResponse> CategoryList();
        int GetCategoryID(GetCategoryIDRequest categoryIDRequest);
        int AddCategory(AddCategoryRequest addCategoryRequest);
        bool CheckCategoryName(CheckCategoryName checkCategory);
        #endregion

        #region Unit Operations
        List<UnitListResponse> UnitList();
        int GetUnitID(UnitIDRequest unitIDRequest);
        #endregion

        #region StockOperations
        bool GetStockStatusID(GetStockStatusIDRequest statusIDRequest);
        List<ListStockStatus> StockStatusList();
        #endregion

    }
}

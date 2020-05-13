using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Product;
using Winkel.Contracts.Response.Product;
using Winkel.Services.StockStatusServices;
using Winkel.Services.UnitServices;
using WinkelDAL.Context;
using WinkelDAL.Model;
using Winkel.Services.StockServices;
using Winkel.Contracts.Request.Category;
using Winkel.Contracts.Response.Category;
using Winkel.Contracts.Request.Unit;
using Winkel.Contracts.Response.Unit;
using Winkel.Contracts.Request.StockStatus;
using Winkel.Contracts.Response.StockStatus;

namespace Winkel.Services.ProductServices
{
    public class ProductService : IProductService
    {
        ICategoryService categoryService = new CategoryService();
        IUnitService unitService = new UnitService();
        IStockStatusService statusService = new StockStatusService();
        public List<ActiveProductListResponse> ActiveProductList()
        {
            
            using (DataAccess dataAccess = new DataAccess())
            {
                var list = from product in dataAccess.Products
                           join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                           join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                           join seller in dataAccess.Sellers on product.SellerID equals seller.SellerID
                           join city in dataAccess.Cities on seller.CityID equals city.CityID
                           join status in dataAccess.StockStatus on product.StockID equals status.StockID
                           where (product.StatusID == true && product.StockID == true)
                           select (new ActiveProductListResponse
                           {
                               ProductID = product.ProductID,
                               CategoryName = category.CategoryName,
                               ProductCode = product.ProductCode,
                               ProductName = product.ProductName,
                               Volume = product.Volume,
                               UnitName = unit.UnitName,
                               SellerName = seller.Name,
                               SellerSurame = seller.Surname,
                               SellerEmail = seller.Email,
                               SellerCity = city.CityName,
                               StockNumber = product.StockNumber,
                               Price = product.Price,
                               Photo = product.Photo,
                               StockStatus=status.StockStatu
                           });
                return list.ToList();

            }
        }

        public int AddCategory(AddCategoryRequest addCategoryRequest)
        {
            return categoryService.AddCategory(addCategoryRequest);
        }

        public int AddProduct(AddProductRequest addProduct)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                Product product = new Product();
                product.CategoryID = categoryService.GetCategoryID(new Contracts.Request.Category.GetCategoryIDRequest(addProduct.CategoryName));
                product.ProductCode = addProduct.ProductCode;
                product.ProductName = addProduct.ProductName;
                product.Volume = addProduct.Volume;
                product.UnitID = GetUnitID(new UnitIDRequest(addProduct.UnitName));
                product.SellerID = addProduct.SellerID;
                product.StockNumber = addProduct.StockNumber;
                product.Price = addProduct.Price;
                product.Photo = addProduct.Photo;
                dataAccess.Products.Add(product);
                return dataAccess.SaveChanges();
            }
        }

        public List<SellerProductResponse> AllProductList(AllProductRequest allProduct)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var list = from product in dataAccess.Products
                           join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                           join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                           join seller in dataAccess.Sellers on product.SellerID equals seller.SellerID
                           join city in dataAccess.Cities on seller.CityID equals city.CityID
                           join stockStatus in dataAccess.StockStatus on product.StockID equals stockStatus.StockID
                           where (product.SellerID==allProduct.SellerID && product.StatusID==true)
                           orderby product.StockID descending
                           select (new SellerProductResponse
                           {
                               ProductID = product.ProductID,
                               CategoryName = category.CategoryName,
                               ProductCode = product.ProductCode,
                               ProductName = product.ProductName,
                               Volume = product.Volume,
                               UnitName = unit.UnitName,
                               StockNumber = product.StockNumber,
                               Price = product.Price,
                               Photo = product.Photo,
                               StockStatus = stockStatus.StockStatu
                           });
                return list.ToList();
            }
        }
        public decimal CalculateCost(CalculateCostRequest costRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var calculatedProduct = dataAccess.Products.Where(x => x.ProductID == costRequest.ProductID).FirstOrDefault<Product>();
                return (calculatedProduct.Price * costRequest.SalesNumber);
            }
        }

        public List<CategoryListResponse> CategoryList()
        {
            return categoryService.CategoryList();
        }

        public bool CheckCategoryName(CheckCategoryName checkCategory)
        {
            return categoryService.CheckCategoryName(checkCategory);
        }

        public bool CheckProductExist(CheckProductExistRequest checkProductExist)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                return ((from product in dataAccess.Products join unit in dataAccess.Unit on product.UnitID equals unit.UnitID where (product.ProductCode == checkProductExist.ProductCode && product.ProductName == checkProductExist.ProductName && product.Volume == checkProductExist.Volume && unit.UnitName == checkProductExist.UnitName && product.SellerID==checkProductExist.SellerID) select (product)).Count()) == 1;    
            }
        }

        public bool CheckStatus(CheckStatusRequest checkStatus)
        {
            throw new NotImplementedException();
        }

        public int DeleteASellerAllProduct(DeleteASellerAllProductRequest deleteASellerAllProduct)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var list = dataAccess.Products.Where(x => x.SellerID == deleteASellerAllProduct.SellerID).ToList();
                foreach (var item in list)
                {
                    item.StatusID = false;
                    item.StockID = false;
                    dataAccess.Products.Update(item);
                }
                return dataAccess.SaveChanges();
            }
        }

        public bool DeleteProduct(DeleteProductRequest deleteProduct)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var deletedProduct = dataAccess.Products.Where(x => x.ProductID == deleteProduct.ProductID).FirstOrDefault<Product>();
                deletedProduct.StockID = false;
                deletedProduct.StatusID = false;
                dataAccess.Update(deletedProduct);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public int GetCategoryID(GetCategoryIDRequest categoryIDRequest)
        {
            return categoryService.GetCategoryID(categoryIDRequest);
        }

        public int GetProductID(GetProductIDRequest getProductID)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var product = (from p in dataAccess.Products
                               join category in dataAccess.Categories on p.CategoryID equals category.CategoryID
                               join unit in dataAccess.Unit on p.UnitID equals unit.UnitID
                               join seller in dataAccess.Sellers on p.SellerID equals seller.SellerID
                               where (category.CategoryName == getProductID.CategoryName && p.ProductCode == getProductID.ProductCode && p.ProductName == getProductID.ProductName && p.Volume == getProductID.Volume && unit.UnitName == getProductID.UnitName && seller.Name == getProductID.SellerName && seller.Surname == getProductID.SellerSurname)
                               select new
                               {
                                   ProductID = p.ProductID,
                                   CategoryName = category.CategoryName,
                                   ProductCode = p.ProductCode,
                                   ProductName = p.ProductName,
                                   Volume = p.Volume,
                                   UnitName = unit.UnitName,
                                   SellerName = seller.Name,
                                   SellerSurname = seller.Surname

                               }).ToList();
                return product[0].ProductID;
            }
        }

        public bool GetStockStatusID(GetStockStatusIDRequest statusIDRequest)
        {
            return statusService.GetStockStatusID(statusIDRequest);
        }

        public int GetUnitID(UnitIDRequest unitIDRequest)
        {
            return unitService.GetUnitID(unitIDRequest);
        }

        public List<ActiveProductListResponse> SearchProduct(SearchProductRequest searchProductRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var list = from product in dataAccess.Products
                           join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                           join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                           join seller in dataAccess.Sellers on product.SellerID equals seller.SellerID
                           join city in dataAccess.Cities on seller.CityID equals city.CityID
                           join stockStatus in dataAccess.StockStatus on product.StockID equals stockStatus.StockID
                           where (product.StatusID == true && (product.ProductCode.StartsWith(searchProductRequest.query) || product.ProductName.StartsWith(searchProductRequest.query)))
                           orderby product.StockID descending
                           select (new ActiveProductListResponse
                           {
                               ProductID = product.ProductID,
                               CategoryName = category.CategoryName,
                               ProductCode = product.ProductCode,
                               ProductName = product.ProductName,
                               Volume = product.Volume,
                               UnitName = unit.UnitName,
                               SellerName = seller.Name,
                               SellerSurame = seller.Surname,
                               SellerEmail = seller.Email,
                               SellerCity = city.CityName,
                               StockNumber = product.StockNumber,
                               Price = product.Price,
                               Photo = product.Photo,
                               StockStatus = stockStatus.StockStatu
                           });
                return list.ToList();
            }
        }

        public List<SellerProductResponse> SellerProductSearch(SellerProductSearchRequest searchProductRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var list = from product in dataAccess.Products
                           join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                           join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                           join seller in dataAccess.Sellers on product.SellerID equals seller.SellerID
                           join city in dataAccess.Cities on seller.CityID equals city.CityID
                           join stockStatus in dataAccess.StockStatus on product.StockID equals stockStatus.StockID
                           where (product.StatusID == true && product.SellerID==searchProductRequest.SellerID && (product.ProductCode.StartsWith(searchProductRequest.query) || product.ProductName.StartsWith(searchProductRequest.query)))
                           orderby product.StockID descending
                           select (new SellerProductResponse
                           {
                               ProductID = product.ProductID,
                               CategoryName = category.CategoryName,
                               ProductCode = product.ProductCode,
                               ProductName = product.ProductName,
                               Volume = product.Volume,
                               UnitName = unit.UnitName,
                               StockNumber = product.StockNumber,
                               Price = product.Price,
                               Photo = product.Photo,
                               StockStatus = stockStatus.StockStatu
                           });
                return list.ToList();
            }
        }

        public List<int> stockNumberRequest(StockNumberRequest stockNumberRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var stockNumber = dataAccess.Products.Where(x => x.ProductID == stockNumberRequest.ProductID).Select(x => x.StockNumber);
                List<int> StockNumberList = new List<int>();
                for (int i = 1; i <= Convert.ToInt16(stockNumber); i++)
                {
                    StockNumberList.Add(i);
                }
                return StockNumberList;
            }
        }

        public List<ListStockStatus> StockStatusList()
        {
            return statusService.StockStatusList();
        }

        public List<UnitListResponse> UnitList()
        {
            return unitService.UnitList();
        }

        public bool UpdateProduct(UpdateProductRequest updateProduct)
        {
            using (DataAccess dataAccess= new DataAccess())
            {
                var updatedProduct = dataAccess.Products.Where(x => x.ProductID == updateProduct.ProductID).FirstOrDefault<Product>();
                updatedProduct.CategoryID = GetCategoryID(new GetCategoryIDRequest(updateProduct.CategoryName));
                updatedProduct.ProductCode = updateProduct.ProductCode;
                updatedProduct.ProductName = updateProduct.ProductName;
                updatedProduct.Volume = updateProduct.Volume;
                updatedProduct.UnitID = GetUnitID(new UnitIDRequest(updateProduct.UnitName));
                updatedProduct.SellerID = updateProduct.SellerID;
                updatedProduct.StockNumber = updateProduct.StockNumber;
                updatedProduct.StockID = GetStockStatusID(new GetStockStatusIDRequest(updateProduct.StockStatus));
                updatedProduct.Price = updateProduct.Price;
                updatedProduct.Photo = updateProduct.Photo;
                dataAccess.Products.Update(updatedProduct);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public bool UpdateStockNumber(UpdateStockNumberRequest updateStockNumber)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                var product = dataAccess.Products.Where(x => x.ProductID == updateStockNumber.ProductID).FirstOrDefault<Product>();
                product.StockNumber -= updateStockNumber.SalesNumber;
                if (product.StockNumber == 0)
                {
                    product.StockID = false;
                    dataAccess.Products.Update(product);
                    return dataAccess.SaveChanges() > 0;
                }
                else
                {
                    dataAccess.Products.Update(product);
                    return dataAccess.SaveChanges() > 0;
                }
            }
        }

    }
}

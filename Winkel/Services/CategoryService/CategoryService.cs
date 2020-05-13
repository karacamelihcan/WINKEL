using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Category;
using Winkel.Contracts.Response.Category;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public class CategoryService:ICategoryService
    {
        public CategoryService()
        {

        }
        DataAccess dataAccess = new DataAccess();
        public int AddCategory(AddCategoryRequest addCategoryRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                Category category = new Category();
                category.CategoryName = addCategoryRequest.CategoryName;
                dataAccess.Categories.Add(category);
                return dataAccess.SaveChanges();
            }
        }

        public List<CategoryListResponse> CategoryList()
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var categories = from category in dataAccess.Categories
                                select new CategoryListResponse { CategoryName = category.CategoryName };
                return categories.ToList();
            }
        }

        public int GetCategoryID(GetCategoryIDRequest categoryIDRequest)
        {
            using (DataAccess dataAccess=new DataAccess())
            {

                return dataAccess.Categories.Where(x => x.CategoryName == categoryIDRequest.CategoryName).Select(x => x.CategoryID).ToArray()[0];
            }
        }

        public bool CheckCategoryName(CheckCategoryName checkCategory)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                return dataAccess.Categories.Where(x => x.CategoryName == checkCategory.CategoryName).Count() < 1;
            }
        }
    }
}

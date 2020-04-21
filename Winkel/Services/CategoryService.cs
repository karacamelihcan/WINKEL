using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public class CategoryService:ICategoryService
    {
        public CategoryService()
        {

        }

        public int AddCategory(Category category)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                dataAccess.Categories.Add(category);
                return dataAccess.SaveChanges();
            }
        }

        public List<Category> CategoryList()
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                return dataAccess.Categories.ToList();
            }
        }

        public int GetCategoryID(string categoryName)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                return dataAccess.Categories.Where(x => x.CategoryName == categoryName).Select(x => x.CategoryID).ToArray()[0];
            }
        }
    }
}

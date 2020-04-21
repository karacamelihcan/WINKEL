using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public interface ICategoryService
    {
        List<Category> CategoryList();
        int GetCategoryID(string categoryName);
        int AddCategory(Category category);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Category;
using Winkel.Contracts.Response.Category;

namespace Winkel.Services
{
    public interface ICategoryService
    {
        List<CategoryListResponse> CategoryList();
        int GetCategoryID(GetCategoryIDRequest categoryIDRequest);
        int AddCategory(AddCategoryRequest addCategoryRequest);
        bool CheckCategoryName(CheckCategoryName checkCategory);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Category
{
    public class GetCategoryIDRequest
    {
        public GetCategoryIDRequest(string CategoryName)
        {
            this.CategoryName = CategoryName;
        }
        public string CategoryName { get; set; }
    }
}

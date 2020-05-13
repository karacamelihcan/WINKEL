using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class SearchProductRequest
    {
        public SearchProductRequest(string query)
        {
            this.query = query;
        }
        public string query { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Product
{
    public class DeleteProductRequest
    {
        public DeleteProductRequest(int ProductID)
        {
            this.ProductID = ProductID;
        }
        public int ProductID { get; set; }
    }
}

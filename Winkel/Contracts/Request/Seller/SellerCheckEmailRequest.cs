using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public  class SellerCheckEmailRequest
    {
        public SellerCheckEmailRequest(string Email)
        {
            this.Email = Email;
        }
        public string Email { get; set; }
    }
}

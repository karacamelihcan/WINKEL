using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public class ForgotPasswordRequest
    {
        public ForgotPasswordRequest(string Email)
        {
            this.Email = Email;
        }
        public string Email { get; set; }
   
    }
}

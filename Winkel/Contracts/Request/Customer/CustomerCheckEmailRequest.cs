using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Customer
{
    public  class CustomerCheckEmailRequest
    {
        public CustomerCheckEmailRequest(string Email)
        {
            this.Email = Email;
        }
        public string Email { get; set; }
    }
}

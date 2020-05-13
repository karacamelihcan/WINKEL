using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Request.Seller
{
    public class GetSellerID
    {
        public GetSellerID(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public GetSellerID(string SellerName,string SellerSurname, string Email)
        {
            this.SellerName = SellerName;
            this.SellerSurname = SellerSurname;
            this.Email = Email;
        }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

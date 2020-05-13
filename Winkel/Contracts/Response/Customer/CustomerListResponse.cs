using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winkel.Contracts.Response.Customer
{
    public class CustomerListResponse
    {
        public CustomerListResponse()
        {

        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CityName { get; set; }
        public string Photo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinkelDAL.Model;
using WinkelDAL.InnerJoin;

namespace Winkel.Services
{
    public interface ICustomerService
    {
        List<CustomerInnerJoin> GetCustomer();
        bool LogIn(Customer customer);
        int Register(Customer customer);
        bool Delete(Customer customer);
        bool Update(Customer customer);
        List<CustomerInnerJoin> SearchCustomer(string query);
        List<SalesListCustomer> PastOperations(Customer customer);

    }
}

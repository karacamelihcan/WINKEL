using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Notification;
using Winkel.Contracts.Request.Product;
using Winkel.Contracts.Request.Sales;
using Winkel.Contracts.Request.Seller;
using Winkel.Services;
using Winkel.Services.ProductServices;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services.SalesServices
{
   
    public class SalesService : ISalesService
    {
        ISellerService sellerService = new SellerService();
        IProductService productService = new ProductService();
        INotificationService notificationService = new NotificationService();

        public int AddNotf(AddNotificationRequest addNotification)
        {
            return notificationService.AddNotification(new AddNotificationRequest(addNotification.SalesID));
        }

        public int AddSales(AddSalesRequest addSales)
        {
            using (DataAccess dataAccess=new DataAccess())
            {
                Sales sales = new Sales();
                sales.SellerID = sellerService.GetSellerID(new Contracts.Request.Seller.GetSellerID(addSales.SellerName, addSales.SellerSurname, addSales.SellerEmail));
                sales.CustomerID = addSales.CustomerID;
                sales.ProductID = addSales.ProductID;
                sales.SalesNumber = addSales.SalesNumber;
                sales.Cost = addSales.Cost;
                dataAccess.Sales.Add(sales);
                UpdateStockNumber(new UpdateStockNumberRequest(addSales.ProductID, addSales.SalesNumber));
                dataAccess.SaveChanges();
                var addedsales = dataAccess.Sales.Where(x => x.CustomerID == sales.CustomerID && x.SellerID == sales.SellerID && x.ProductID == sales.ProductID && x.SalesNumber == sales.SalesNumber && x.Cost == sales.Cost).OrderBy(x => x.SalesID);


                AddNotf(new AddNotificationRequest(addedsales.FirstOrDefault().SalesID));
                return dataAccess.SaveChanges();
            }
        }

        public decimal CalcuteCost(CalculateCostRequest costRequest)
        {
            return productService.CalculateCost(costRequest);
        }

        public int GetSellerID(GetSellerID getSellerID)
        {
            return sellerService.GetSellerID(getSellerID);
        }

        public bool UpdateStockNumber(UpdateStockNumberRequest updateStockNumber)
        {
            return productService.UpdateStockNumber(updateStockNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Notification;
using Winkel.Contracts.Request.Product;
using Winkel.Contracts.Request.Sales;
using Winkel.Contracts.Request.Seller;

namespace Winkel.Services.SalesServices
{
    public interface ISalesService
    {
        int AddSales(AddSalesRequest addSales);
        int GetSellerID(GetSellerID getSellerID);
        bool UpdateStockNumber(UpdateStockNumberRequest updateStockNumber);
        decimal CalcuteCost(CalculateCostRequest costRequest);
        int AddNotf(AddNotificationRequest addNotification);
    }
}

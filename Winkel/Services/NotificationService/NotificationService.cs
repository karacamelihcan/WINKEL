using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Notification;
using Winkel.Contracts.Response.Notification;
using WinkelDAL.Context;
using WinkelDAL.Model;

namespace Winkel.Services
{
    public class NotificationService : INotificationService
    {
        public int AddNotification(AddNotificationRequest addNotification)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var notf = new Notification();
                notf.SalesID = addNotification.SalesID;
                dataAccess.Notifications.Add(notf);
                return dataAccess.SaveChanges();
            }
        }

        public List<NotificationListResponse> NotificationList(SellerNotificationRequest notificationRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var notifications = from notf in dataAccess.Notifications
                                    join selectedSales in dataAccess.Sales on notf.SalesID equals selectedSales.SalesID
                                    join customer in dataAccess.Customers on selectedSales.CustomerID equals customer.CustomerID
                                    join city in dataAccess.Cities on customer.CityID equals city.CityID
                                    join product in dataAccess.Products on selectedSales.ProductID equals product.ProductID
                                    join category in dataAccess.Categories on product.CategoryID equals category.CategoryID
                                    join unit in dataAccess.Unit on product.UnitID equals unit.UnitID
                                    join readstatus in dataAccess.ReadStatus on notf.ReadID equals readstatus.ReadID
                                    where (selectedSales.SellerID == notificationRequest.SellerID)
                                    select new NotificationListResponse
                                    {
                                        NotfID = notf.NotfID,
                                        CustomerName = customer.Name,
                                        CustomerSurname = customer.Surname,
                                        CustomerEmail = customer.Email,
                                        CustomerCity = city.CityName,
                                        ProductCategory = category.CategoryName,
                                        ProductCode = product.ProductCode,
                                        ProductName = product.ProductName,
                                        Volume = product.Volume,
                                        ProductUnit = unit.UnitName,
                                        SalesNumber = selectedSales.SalesNumber,
                                        Cost = selectedSales.Cost,
                                        Read = readstatus.ReadName
                                    };
                return notifications.OrderByDescending(x=>x.Read).ThenByDescending(x=>x.NotfID).ToList();
            }
        }

        public bool ReadNotification(ReadNotificationRequest readRequest)
        {
            using(DataAccess dataAccess=new DataAccess())
            {
                var selectedNotf = dataAccess.Notifications.Where(x => x.NotfID == readRequest.NotfID).FirstOrDefault<Notification>();
                selectedNotf.ReadID = true;
                dataAccess.Notifications.Update(selectedNotf);
                return dataAccess.SaveChanges() > 0;
            }
        }

        public bool UnReadNotification(UnReadNotificationRequest unreadRequest)
        {
            using (DataAccess dataAccess = new DataAccess())
            {
                var selectedNotf = dataAccess.Notifications.Where(x => x.NotfID == unreadRequest.NotfID).FirstOrDefault<Notification>();
                selectedNotf.ReadID = false;
                dataAccess.Notifications.Update(selectedNotf);
                return dataAccess.SaveChanges() > 0;
            }
        }
    }
}

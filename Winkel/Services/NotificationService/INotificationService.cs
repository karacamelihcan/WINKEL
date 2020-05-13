using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winkel.Contracts.Request.Notification;
using Winkel.Contracts.Response.Notification;


namespace Winkel.Services
{
    public interface INotificationService
    {
        int AddNotification(AddNotificationRequest addNotification);
        List<NotificationListResponse> NotificationList(SellerNotificationRequest notificationRequest);
        bool ReadNotification(ReadNotificationRequest readRequest);
        bool UnReadNotification(UnReadNotificationRequest unreadRequest);
    }
}

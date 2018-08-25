using Erpmi.Core.Models;
using Basics.PatternsAndPractices;

namespace Erpmi.Core.Repositories
{
    public interface INotificationRepository :
        IRepository<Notification, int>,
        IPagingRepository<Notification>,
        IAsyncRepository<Notification, int>,
        IAsyncPagingRepository<Notification>
    {
        //IEnumerable<Notification> GetNotificationsForUser(ApplicationUser user);
        //IEnumerable<Notification> GetNotificationsForUser(ApplicationUser user, DateTime datingBackTo);
        //IEnumerable<Notification> GetNotificationsForUser(ApplicationUser user, int pageIndex, int pageSize);
        //IEnumerable<Notification> GetUnreadNotificationsForUser(ApplicationUser user);
        //IEnumerable<Notification> GetUnreadNotificationsForUser(ApplicationUser user, int pageIndex, int pageSize);
        //int HowManyUnreadNotificationsForUser(ApplicationUser user);
    }
}

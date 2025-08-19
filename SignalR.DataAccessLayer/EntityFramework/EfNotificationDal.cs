using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        private readonly Context _context;
        public EfNotificationDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ChangeStatusNotification(int id)
        {
            _context.Notifications.Where(x => x.Id == id).ToList().ForEach(x => x.Status = !x.Status);
            _context.SaveChanges();
        }

        public List<Notification> GetListByStatusFalse()
        {
            return _context.Notifications
                .Where(x => x.Status == false)
                .OrderByDescending(x => x.Date)
                .ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            return _context.Notifications.Count(x => x.Status == false);
        }
    }
}

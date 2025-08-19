using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void ChangeStatusNotification(int id)
        {
            _notificationDal.ChangeStatusNotification(id);
        }

        public List<Notification> GetListByStatusFalse()
        {
            return _notificationDal.GetListByStatusFalse();
        }

        public int NotificationCountByStatusFalse()
        {
            return _notificationDal.NotificationCountByStatusFalse();
        }

        public void TAdd(Notification t)
        {
            _notificationDal.Add(t);
        }

        public void TDelete(Notification t)
        {
            _notificationDal.Delete(t);
        }

        public Notification TGetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public List<Notification> TGetList()
        {
            return _notificationDal.GetList();
        }

        public void TUpdate(Notification t)
        {
            _notificationDal.Update(t);
        }
    }
}

using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.EntityFramework;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void TAdd(OrderDetail t)
        {
            _orderDetailDal.Add(t);
        }

        public void TDelete(OrderDetail t)
        {
            _orderDetailDal.Delete(t);
        }

        public OrderDetail TGetById(int id)
        {
            return _orderDetailDal.GetById(id);
        }

        public List<OrderDetail> TGetList()
        {
            return _orderDetailDal.GetList();
        }

        public void TUpdate(OrderDetail t)
        {
            _orderDetailDal.Update(t);
        }
    }
}

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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        private readonly Context _context;
        public EfOrderDal(Context context) : base(context)
        {
            _context = context;
        }

        public int ActiveOrderCount()
        {
            return _context.Orders.Count(x => x.Description == "Müşteri Masada");
        }

        public decimal LastOrderPrice()
        {
            return _context.Orders
                .OrderByDescending(x => x.Id).Take(1)
                .Select(x => x.TotalPrice)
                .FirstOrDefault();
        }

        public decimal TodayTotalPrice()
        {
            return _context.Orders
                .Where(x => x.Date.Date == DateTime.Now.Date && x.Description == "Hesap Kapatıldı")
                .Sum(x => x.TotalPrice);
        }

        public int TotalOrderCount()
        {
            return _context.Orders.Count();
        }
    }
}

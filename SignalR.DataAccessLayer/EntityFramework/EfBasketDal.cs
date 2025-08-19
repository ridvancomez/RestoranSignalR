using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DTOLayer.Basket;
using SignalR.EntityLayer.Entites;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        private readonly Context _context;
        public EfBasketDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Basket> GetListByMenuTableId(int menuTableId)
        {
            return _context.Baskets
                .Where(b => b.MenuTableId == menuTableId).Include(b => b.Product)
                .ToList();
        }
    }
}

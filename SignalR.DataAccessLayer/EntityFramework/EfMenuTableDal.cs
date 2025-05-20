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
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        private readonly Context _context;
        // You can add any additional methods specific to MenuTable here if needed
        public EfMenuTableDal(Context context) : base(context)
        {
            _context = context;
        }

        public int MenuTableCount()
        {
            return _context.Set<MenuTable>().Count();
        }
    }
}

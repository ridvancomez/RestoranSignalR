using Microsoft.EntityFrameworkCore;
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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly Context _context;
        public EfCategoryDal(Context context) : base(context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            var activeCategoryCount = _context.Categories.Count(x => x.Status == true);
            return activeCategoryCount;
        }

        public int CategoryCount()
        {
            return _context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            var passiveCategoryCount = _context.Categories.Count(x => x.Status == false);
            return passiveCategoryCount;
        }
    }
}

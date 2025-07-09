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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public decimal GetAveragePriceProduct()
        {
            return (decimal)_context.Products
                .Average(x => x.Price);
        }

        public string GetMaxPriceProductName()
        {
            return _context.Products.Where(x => x.Price == _context.Products.Max(y => y.Price)).Select(z => z.Name).FirstOrDefault() ?? "Ürün Bulunamadı";
        }

        public string GetMinPriceProductName()
        {
            return _context.Products.Where(x => x.Price == _context.Products.Min(y => y.Price)).Select(z => z.Name).FirstOrDefault() ?? "Ürün Bulunamadı";
        }

        public List<Product> GetProductsWithCategory()
        {
            var list = _context.Products
                .Include(x => x.Category)
                .ToList();

            return list;
        }

        public int ProductCount()
        {
            return _context.Products.Count();
        }

        public int ProductCountByDrink()
        {
            return _context.Products
                .Where(x => x.CategoryId == 
                _context.Categories.Where(y => y.Name == "İçecek").Select(z=> z.Id).FirstOrDefault())
                .Count();
        }

        public int ProductCountByHamburger()
        {
            return _context.Products
                .Where(x => x.CategoryId ==
                _context.Categories.Where(y => y.Name == "Hamburger").Select(z => z.Id).FirstOrDefault())
                .Count();
        }

        public decimal ProductAvgPriceByHamburger()
        {
            return _context.Products.
                Where(x => x.CategoryId == _context.Categories.
                Where(y => y.Name == "Hamburger").
                Select(z => z.Id).FirstOrDefault()).Average(w => w.Price);
        }

        public List<Product> GetProductWithFeatured()
        {
            return _context.Products
                .Where(x => x.Featured == true && x.Status == true)
                .Include(x => x.Category)
                .ToList();
        }
    }
}

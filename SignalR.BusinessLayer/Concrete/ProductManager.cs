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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TAdd(Product t)
        {
            _productDal.Add(t);
        }
        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }
        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public int TProductCount()
        {
            return _productDal.ProductCount();
        }

        public int TGetProductCountByDrink()
        {
            return _productDal.ProductCountByDrink();
        }

        public int TGetProductCountByHamburger()
        {
            return _productDal.ProductCountByHamburger();
        }

        public decimal TGetAveragePriceProduct()
        {
            return _productDal.GetAveragePriceProduct();
        }

        public string TGetMaxPriceProductName()
        {
            return _productDal.GetMaxPriceProductName();
        }

        public string TGetMinPriceProductName()
        {
            return _productDal.GetMinPriceProductName();
        }

        public decimal TProductAvgPriceByHamburger()
        {
            return _productDal.ProductAvgPriceByHamburger();
        }

        public List<Product> TGetProductWithFeatured()
        {
            return _productDal.GetProductWithFeatured();
        }
    }
}

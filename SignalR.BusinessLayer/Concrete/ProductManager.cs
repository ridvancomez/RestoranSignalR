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
    }
}

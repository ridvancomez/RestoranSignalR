using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategory();
        int ProductCount();

        int ProductCountByHamburger();
        int ProductCountByDrink();
        decimal GetAveragePriceProduct();
        string GetMaxPriceProductName();
        string GetMinPriceProductName();
        decimal ProductAvgPriceByHamburger();
    }
}

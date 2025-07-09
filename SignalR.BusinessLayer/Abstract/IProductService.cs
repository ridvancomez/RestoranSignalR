using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategory();

        int TProductCount();

        int TGetProductCountByDrink();
        int TGetProductCountByHamburger();

        decimal TGetAveragePriceProduct();
        string TGetMaxPriceProductName();
        string TGetMinPriceProductName();
        decimal TProductAvgPriceByHamburger();
        List<Product> TGetProductWithFeatured();
    }
}

using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.ProductFature
{
    public class ProductCrudEventStrategy : ICrudEventStrategy
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly IProductService _productService;


        public ProductCrudEventStrategy(IHubContext<SignalRHub> hubContext, IProductService productService)
        {
            _hubContext = hubContext;
            _productService = productService;
        }
        public async void OnChanged()
        {
            var productCount = _productService.TProductCount();
            var hamburgerCount = _productService.TGetProductCountByHamburger();
            var drinkCount = _productService.TGetProductCountByDrink();
            var avgProductPrice = _productService.TGetAveragePriceProduct();
            var maxProductPrice = _productService.TGetMaxPriceProductName();
            var minProductPrice = _productService.TGetMinPriceProductName();
            var avgHamburgerPrice = _productService.TProductAvgPriceByHamburger();

            await _hubContext.Clients.All.SendAsync("ReceiveProduct", productCount);
            await _hubContext.Clients.All.SendAsync("ReceiveHamburgerCount", hamburgerCount);
            await _hubContext.Clients.All.SendAsync("ReceiveDrinkCount", drinkCount);
            await _hubContext.Clients.All.SendAsync("ReceiveAvgProductPrice", avgProductPrice);
            await _hubContext.Clients.All.SendAsync("ReceiveMaxProductPrice", maxProductPrice);
            await _hubContext.Clients.All.SendAsync("ReceiveMinProductPrice", minProductPrice);
            await _hubContext.Clients.All.SendAsync("ReceiveAvgHamburgerPrice", avgHamburgerPrice);
        }
    }
}

using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;


        public SignalRHub(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task SendCategoryCount()
        {
            var categoryCount = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategory", categoryCount);
        }

        public async Task SendProductCount()
        {
            var productCount = _productService.TProductCount();

            await Clients.All.SendAsync("ReceiveProduct", productCount);
        }

        public async Task SendActiveCategoryCount()
        {
            var activeCategoryCount = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategory", activeCategoryCount);
        }

        public async Task SendPassiveCategoryCount()
        {
            var passiveCategoryCount = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategory", passiveCategoryCount);
        }
    }
}

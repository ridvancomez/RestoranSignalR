using SignalRApi.Features.Shared;
using SignalR.EntityLayer.Entites;
using SignalRApi.Hubs;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
namespace SignalRApi.Features.CategoryFeature
{
    public class CategoryCrudEventStrategy : ICrudEventStrategy
    {

        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly ICategoryService _categoryService;

        public CategoryCrudEventStrategy(IHubContext<SignalRHub> hubContext, ICategoryService categoryService)
        {
            _hubContext = hubContext;
            _categoryService = categoryService;
        }

        public async void OnChanged()
        {
            var categoryCount = _categoryService.TCategoryCount();
            var activeCategoryCount = _categoryService.TActiveCategoryCount();
            var passiveCategoryCount = _categoryService.TPassiveCategoryCount();

            await _hubContext.Clients.All.SendAsync("ReceiveCategory", categoryCount);
            await _hubContext.Clients.All.SendAsync("ReceiveActiveCategory", activeCategoryCount);
            await _hubContext.Clients.All.SendAsync("ReceivePassiveCategory", passiveCategoryCount);
        }
    }
}

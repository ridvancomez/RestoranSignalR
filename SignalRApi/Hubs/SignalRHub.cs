using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
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

        public async Task SendHamburgerCount()
        {
            var hamburgerCount = _productService.TGetProductCountByHamburger();
            await Clients.All.SendAsync("ReceiveHamburgerCount", hamburgerCount);
        }

        public async Task SendDrinkCount()
        {
            var drinkCount = _productService.TGetProductCountByDrink();
            await Clients.All.SendAsync("ReceiveDrinkCount", drinkCount);
        }

        public async Task SendAvgProductPrice()
        {
            var avgProductPrice = _productService.TGetAveragePriceProduct();
            await Clients.All.SendAsync("ReceiveAvgProductPrice", avgProductPrice);
        }

        public async Task SendMaxProductPrice()
        {
            var maxProductPrice = _productService.TGetMaxPriceProductName();
            await Clients.All.SendAsync("ReceiveMaxProductPrice", maxProductPrice);
        }

        public async Task SendMinProductPrice()
        {
            var minProductPrice = _productService.TGetMinPriceProductName();
            await Clients.All.SendAsync("ReceiveMinProductPrice", minProductPrice);
        }

        public async Task SendAvgHamburgerPrice()
        {
            var avgHamburgerPrice = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveAvgHamburgerPrice", avgHamburgerPrice);
        }

        public async Task SendOrderCount()
        {
            var orderCount = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveOrderCount", orderCount);
        }

        public async Task SendActiveOrderCount()
        {
            var activeOrderCount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);
        }

        public async Task SendLastOrderAmount()
        {
            var lastOrderAmount = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderAmount", lastOrderAmount);
        }

        public async Task SendMoneyCaseAmount()
        {
            var moneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveMoneyCaseAmount", moneyCaseAmount);
        }

        public async Task SendMenuTableCount()
        {
            var menuTableCount = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", menuTableCount);
        }

        public async Task SendMenuTable()
        {
            var value = _menuTableService.TGetList();
            await Clients.All.SendAsync("ReceiveMenuTable", value);
        }


        public async Task GetBookingList()
        {
            var bookingList = _bookingService.TGetList();
            await Clients.All.SendAsync("ReceiveBookingList", bookingList);
        }

        public async Task SendNotification()
        {
            var value = _notificationService.NotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);
        }

        public async Task GetNotificationList()
        {
            var notifications = _notificationService.GetListByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationList", notifications);
        }
    }
}

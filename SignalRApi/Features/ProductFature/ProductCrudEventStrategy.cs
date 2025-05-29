using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.ProductFature
{
    public class ProductCrudEventStrategy : ICrudEventStrategy
    {
        private readonly SignalRHub _signalRHub;

        public ProductCrudEventStrategy(SignalRHub signalRHub)
        {
            _signalRHub = signalRHub;
        }
        public async void OnChanged()
        {
            await _signalRHub.SendProductCount();
        }
    }
}

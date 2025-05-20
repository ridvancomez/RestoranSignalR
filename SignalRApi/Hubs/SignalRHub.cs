using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Concrete;
namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly Context _context;
        public SignalRHub(Context context)
        {
            _context = context;
        }

        public async Task SendCategoryCount()
        {
            var value = _context.Categories.Count();

            await Clients.All.SendAsync("ReceiveCategory", value);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Components.LayoutComponents
{
    public class HeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Components.LayoutComponents
{
    public class HeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Components.IndexComponents
{
    public class ContactComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

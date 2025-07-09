using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Components.LayoutComponents
{
    public class ScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

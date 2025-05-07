using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}

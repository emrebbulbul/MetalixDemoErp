using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

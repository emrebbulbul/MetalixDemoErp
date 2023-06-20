using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class TableController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

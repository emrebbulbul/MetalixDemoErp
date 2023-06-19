using BusinessLayer.Operations.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class DangilNoController : Controller
    {
        private readonly DangilNoOperations _dangilNoOperations;

        public DangilNoController(DangilNoOperations dangilNoOperations)
        {
            _dangilNoOperations = dangilNoOperations;
        }

        public IActionResult Index()
        {
            var values = _dangilNoOperations.GetList();
            return View(values);
        }
    }
}

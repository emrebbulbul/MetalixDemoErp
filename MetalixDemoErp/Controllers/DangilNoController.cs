using BusinessLayer.Operations.Implementations;
using BusinessLayer.Operations.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class DangilNoController : Controller
    {
        private readonly IDangilNoOperations _dangilNoOperations;

        public DangilNoController(IDangilNoOperations dangilNoOperations)
        {
            _dangilNoOperations = dangilNoOperations;
        }

        public IActionResult Index()
        {
            //var values = _dangilNoOperations.GetList();
            return View();
        }
    }
}

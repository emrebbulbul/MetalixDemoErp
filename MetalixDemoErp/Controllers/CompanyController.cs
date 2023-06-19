using BusinessLayer.Operations.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyOperations _companyOperations;

        public CompanyController(CompanyOperations companyOperations)
        {
            _companyOperations = companyOperations;
        }

        public IActionResult Index()
        {
            var values = _companyOperations.GetList();
            return View(values);
        }
    }
}

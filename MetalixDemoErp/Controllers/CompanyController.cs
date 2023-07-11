using BusinessLayer.Operations.Implementations;
using BusinessLayer.Operations.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyOperations _companyOperations;

        public CompanyController(ICompanyOperations companyOperations)
        {
            _companyOperations = companyOperations;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        
    }
}

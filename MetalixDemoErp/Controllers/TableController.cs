using BusinessLayer.Operations.Implementations;
using BusinessLayer.Operations.Interfaces;
using DataAccessLayer.Repositories.Implementations;
using DataAccessLayer.Repositories.Interfaces;
using MetalixDemoErp.Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class TableController : Controller
    {
        private readonly ICompanyOperations _companyOperations;
        private readonly IDangilNoOperations _dangilNoOperations;
       

        public TableController(ICompanyOperations companyOperations, IDangilNoOperations dangilNoOperations)
        {
            
            _companyOperations = companyOperations;
            _dangilNoOperations = dangilNoOperations;
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Company t)
        {
           
            _companyOperations.TAdd(t);
            return RedirectToAction("Index","Company");
        }

       
    }
}

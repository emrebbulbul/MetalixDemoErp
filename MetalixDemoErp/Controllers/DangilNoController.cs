﻿using BusinessLayer.Operations.Implementations;
using BusinessLayer.Operations.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MetalixDemoErp.Controllers
{
    public class DangilNoController : Controller
    {
        private readonly ICompanyOperations _companyOperations;
        private readonly IDangilNoOperations _dangilNoOperations;

        public DangilNoController(ICompanyOperations companyOperations, IDangilNoOperations dangilNoOperations)
        {
            _companyOperations = companyOperations;
            _dangilNoOperations = dangilNoOperations;
        }
        

        public IActionResult Index()
        {
            var values = _dangilNoOperations.GetCompanyListWithDangil();
            return View(values);
        }
    }
}

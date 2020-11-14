using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp_net_lab.Models;

namespace asp_net_lab.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel model)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = model.Name.Length,
                NumberOfCharsInDescription = model.Description.Length,
                IsHidden = !model.IsVisible
            };

            return View("CompanyAdded", viewModel);
        }
    }
}

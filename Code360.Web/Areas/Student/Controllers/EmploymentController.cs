using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code360.Web.Areas.Student.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Code360.Web.Areas.Student.Controllers
{
    public class EmploymentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> create(EmploymentViewModel employmentViewModel)
        {
            return RedirectToAction();
        }
    }
}

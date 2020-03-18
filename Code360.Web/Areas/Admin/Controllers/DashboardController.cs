using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[controller]/[action]")]
    public class DashboardController : Controller
    {
       
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

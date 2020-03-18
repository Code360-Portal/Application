using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Code360.Web.Areas.Student.Controllers
{
    [Area("Student")]
    [Route("Student")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("update")]
        public IActionResult Update()
        {
            return View();
        }
    }
}
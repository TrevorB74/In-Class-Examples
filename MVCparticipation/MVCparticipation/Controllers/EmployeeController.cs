using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCparticipation.Controllers
{
    public class EmployeeController : Controller
    {
       
        public IActionResult Index()
        {

            EmployeeController info = new EmployeeController();
            

            return View();
        }

        public IActionResult EmployeeInfo()
        {

            ViewBag.message = "I referenced the CDN bootstrap in my html but im not exactly sure what I am doing";

            return View();

        }

    }
}
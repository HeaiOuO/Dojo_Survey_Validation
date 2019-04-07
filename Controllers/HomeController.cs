using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using survey_validation.Models;

namespace survey_validation.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]

        public IActionResult Result(string Name, string Locations, string Languages, string Comments)
        {
            Models.Survey info = new Models.Survey(Name,Locations,Languages,Comments);
            // TryValidateModel(info);
            if (ModelState.IsValid)
            {
                // Console.WriteLine("Here");
                return View("result",info);
            }
            else
            {
                return View("index");
            }            
        }

    }
}

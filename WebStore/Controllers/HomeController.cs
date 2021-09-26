using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("sdbdfsbsd");
            return View(); 
        }
        public IActionResult SecondAction(int id)
        {
            return Content($"SecondAction param {id}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName ="Иван", Patronymic = "Иванович", Age = 159},
            new Employee { Id = 2, LastName = "Петров", FirstName = "Федор", Patronymic = "Иванович", Age = 19 },
            new Employee { Id = 3, LastName = "Сидлоров", FirstName = "Петр", Patronymic = "Иванович", Age = 59 },
        };
        public IActionResult Index()// localhost:5000/Home/Index
        {
            //return Content("sdbdfsbsd");
            return View(); 
        }
        public IActionResult SecondAction(int id)
        {
            return Content($"SecondAction param {id}");
        }

        public IActionResult Employees()// localhost:5001/Home/Employees
        {
            return View(__Employees);
        }
    }
}

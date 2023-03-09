using Microsoft.AspNetCore.Mvc;
using System;
using AppWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletronicos" });
            departments.Add(new Department { Id = 2, Name = "Fashion" });


            return View(departments);
        }
    }
}

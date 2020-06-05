using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestingDemo.Models;

namespace UnitTestingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Priyank",
                    BirthDate = DateTime.Now,
                    Age = 22
                },
                new Employee
                {
                    Id = 2,
                    Name = "Parth",
                    BirthDate = DateTime.Now,
                    Age = 22
                },
                new Employee
                {
                    Id = 3,
                    Name = "Mayur",
                    BirthDate = DateTime.Now,
                    Age = 21
                },
                new Employee
                {
                    Id = 4,
                    Name = "Swati",
                    BirthDate = DateTime.Now,
                    Age = 24
                },
            };
        }

        [HttpGet]
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<Employee> employees = GetEmployeeList();
            return View(employees);
        }
    }
}
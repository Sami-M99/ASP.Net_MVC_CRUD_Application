using ASP.Net_MVC.Abstract;
using ASP.Net_MVC.Concrete.EF;
using ASP.Net_MVC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // Dependency Injection
        private readonly IEmployeeDal _employeeDal;
        public EmployeeController(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IActionResult Index()
        {
            var model = _employeeDal.GetAll();
            return View(model);
        }

        // Add Employee
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return View();
        }

        // Delete Employee
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return View();
        }


        // Update Employee
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return View();
        }

    }
}

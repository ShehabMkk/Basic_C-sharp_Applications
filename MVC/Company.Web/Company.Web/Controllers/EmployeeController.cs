using Company.Service.Interfaces;
using Company.Service.Interfaces.Dto;
using Company.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService,IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        public ActionResult Index(string searchInp)
        {
            IEnumerable<EmployeeDto> employee = new List<EmployeeDto>();
            if (string.IsNullOrEmpty(searchInp))
                employee = _employeeService.GetAll();
            else
                employee = _employeeService.GetEmployeeByName(searchInp);
            return View(employee);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            var departments = _departmentService.GetAll();
            ViewBag.Departments = departments;
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);
                    return RedirectToAction(nameof(Index));
                }
                
                return View(employee);
            }
            catch (Exception ex)
            {
                return View(employee);
            }
        }
        
        public IActionResult Details(int id,string viewName = "Details")
        {
            var Employee = _employeeService.GetById(id);
            if (Employee is null)
                return RedirectToAction("NotFoundPage", null,"Home");

            return View(viewName,Employee);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return Details(id,"Update");
        }

        [HttpPost]
        public IActionResult Update(int? id, Employee Employee)
        {
            if (Employee.Id != id.Value)
                return RedirectToAction("NotFoundPage", null,"Home");

            _employeeService.Update(Employee);
            return RedirectToAction(nameof(Index));
        }

        // public IActionResult Delete(int id)
        // {
        //     var Employee = _employeeService.GetById(id);
        //     if (Employee is null)
        //         return RedirectToAction("NotFoundPage", null,"Home");
        //
        //     _employeeService.Delete(Employee);
        //     return RedirectToAction(nameof(Index));
        // }

    }
}
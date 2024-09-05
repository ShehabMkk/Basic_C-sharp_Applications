using Company.Data.Models;
using Company.Repository.Interface;
using Company.Service.Interfaces.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {

            var Employees = _EmployeeService.GetAll();
            return View(Employees);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _EmployeeService.Add(Employee);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("EmployeeError", "Validation Error");
                
                return View(Employee);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EmployeeError", ex.Message);
                return View(Employee);
            }
        }

        public IActionResult Details(int id,string viewName = "Details")
        {
            var Employee = _EmployeeService.GetById(id);
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

            _EmployeeService.Update(Employee);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Delete(int id)
        {
            var Employee = _EmployeeService.GetById(id);
            if (Employee is null)
                return RedirectToAction("NotFoundPage", null,"Home");
            
            _EmployeeService.Delete(Employee);
            return RedirectToAction(nameof(Index));
        }
    }
}

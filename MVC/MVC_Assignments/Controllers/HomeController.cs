using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers;

public class HomeController : Controller
{
    public IActionResult index()
    {
        return View();
    }
    
}
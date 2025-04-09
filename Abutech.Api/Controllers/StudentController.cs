using Microsoft.AspNetCore.Mvc;

namespace Laptop.API.Controllers;

public class StudentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
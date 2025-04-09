using Microsoft.AspNetCore.Mvc;

namespace Laptop.API.Controllers;

public class ParentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
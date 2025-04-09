using Microsoft.AspNetCore.Mvc;

namespace Laptop.API.Controllers;

public class ResultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
using FirstWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC.Controllers;

public class EmployeeController : Controller
{
    // GET
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        Repository.Create(employee);
        return View("Thanks", employee);
    }
}
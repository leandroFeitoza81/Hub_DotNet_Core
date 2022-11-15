using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Example.Models;

namespace DependencyInjection.Example.Controllers;

public class HomeController : Controller
{
    private readonly IRepostitory _repository;

    public HomeController(IRepostitory repository)
    {
        _repository = repository;
    }
    
    public IActionResult Index()
    {
        return View(_repository.Products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
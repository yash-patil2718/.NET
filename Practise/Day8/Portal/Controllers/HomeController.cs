using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BOL;
using BLL;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Table()
    {
        List<Employee> data =Businesslayer.showEmployee();
        ViewData["emp"]=data;
        Console.WriteLine(ViewData["emp"]);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
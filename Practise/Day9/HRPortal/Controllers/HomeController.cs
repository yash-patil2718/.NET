using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using BLL;
using BOL;
namespace HRPortal.Controllers;

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

    public IActionResult Register(){ 
        return View();
    }


    [HttpPost]
    public IActionResult Register(string CompanyName, string EmployeeName, int EmployeeId){
        BusinessLayer.InsertData(EmployeeId,EmployeeName,CompanyName);
        return RedirectToAction("Login");
    }

    public IActionResult Login(){
        return View();
    }

    static Employee validemployee;
    // =new Employee("fedf","wefwef",21);
    [HttpPost]
    public IActionResult Login(int EmployeeId, string EmployeeName){
        validemployee = BusinessLayer.Login(EmployeeId, EmployeeName);
        if(validemployee!=null){
            // Console.WriteLine("Login Successfull");
            ViewData["employee"]=validemployee;
            // Console.WriteLine(validemployee);
            return RedirectToAction("Profile");
        }
        else{
            // Console.WriteLine("Login Failed");
            return RedirectToAction("Register");
        }
        return View();
    }

    public IActionResult Profile(){
        ViewData["employee"]=validemployee;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

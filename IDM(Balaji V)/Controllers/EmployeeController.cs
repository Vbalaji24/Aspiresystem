using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IdentityManagement.Models;

namespace IdentityManagement.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public EmployeeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

   

   
     [HttpGet]
    public IActionResult EmployeeLogin()
    {
       
        return View();
    }
    [HttpPost]
     public IActionResult EmployeeLogin(User user)
    {
       string result= Database.EmployeeLogin(user);
       Console.WriteLine(result);
       if(result=="success")
       {
          return View("Success",user);
       }
      
       return View("Login",user);
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

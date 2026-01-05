using DotNetMenu.Models;
using DotNetMenu.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetMenu.Controllers;

public class HomeController : Controller
{

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

   
}

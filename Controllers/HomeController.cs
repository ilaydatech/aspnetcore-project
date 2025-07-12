using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    // Home/index.cshtml'i görüntüleme
    public IActionResult Index()
    {
        return View();
    }
    //Home/Contact.cshtml'i görüntüleme
    public IActionResult Contact()
    {
        return View();
    }

}

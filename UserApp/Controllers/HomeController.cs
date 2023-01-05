using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace UserApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
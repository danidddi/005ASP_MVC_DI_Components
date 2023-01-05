using Microsoft.AspNetCore.Mvc;

namespace UserApp.Controllers;

public class UsersController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Posts(int id) => View(id);
    public IActionResult Photos(int id) => View(id);
    public IActionResult Todos(int id) => View(id);
}

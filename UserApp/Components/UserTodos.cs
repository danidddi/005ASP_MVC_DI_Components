using Microsoft.AspNetCore.Mvc;
using UserApp.Models;
using UserApp.Services;

namespace UserApp.Components;

public class UserTodos : ViewComponent
{
    private UserService _service;

    public UserTodos(UserService service) => _service = service;

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        List<Todo> todos = await _service.GetTodosAsync(id);

        ViewBag.Count = todos.Count;
        ViewBag.Done = todos.Count(x => x.Completed);
        ViewBag.Notdone = todos.Count(x => !x.Completed);

        return View(todos);
    }
}

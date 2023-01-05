using Microsoft.AspNetCore.Mvc;
using UserApp.Models;
using UserApp.Services;

namespace UserApp.Components;

public class RegistredUsers : ViewComponent
{
    private UserService _service;

    public RegistredUsers( UserService service) => _service = service;

    public async Task<IViewComponentResult> InvokeAsync()  => View(await _service.GetUsersAsync());
}

using Microsoft.AspNetCore.Mvc;
using UserApp.Models;
using UserApp.Services;

namespace UserApp.Components;

public class UserPhotos : ViewComponent
{
    private UserService _service;

    public UserPhotos(UserService service) => _service = service;

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        List<Photo> photos = await _service.GetPhotosAsync(id);

        ViewBag.Count = photos.Count;

        return View(photos);
    }
}

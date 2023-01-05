using Microsoft.AspNetCore.Mvc;
using UserApp.Models;
using UserApp.Services;

namespace UserApp.Components;

public class UserPosts : ViewComponent
{
    private UserService _service;

    public UserPosts(UserService service) => _service = service;

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        List<Post> posts = await _service.GetPostsAsync(id);
        //выводить количество постов, минимальную, среднюю и максимальную длина текста (поле body) в символах

        ViewBag.Count = posts.Count;
        ViewBag.Min = posts.Min(x => x.Body.Length);
        ViewBag.Avg = posts.Average(x => x.Body.Length);
        ViewBag.Max = posts.Max(x => x.Body.Length);

        return View(posts);
    }
}

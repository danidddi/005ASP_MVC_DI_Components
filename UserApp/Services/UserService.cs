using Newtonsoft.Json;
using UserApp.Models;

namespace UserApp.Services;

public class UserService
{
    private const string _url = "https://jsonplaceholder.typicode.com/";

    //получить пользователей
    public async Task<List<User>> GetUsersAsync()
        => await GetDataAsync<User>($"{_url}users");
    //получить публикации
    public async Task<List<Post>> GetPostsAsync(int id)
        => await GetDataAsync<Post>($"{_url}users/{id}/posts");
    //получить список дел
    public async Task<List<Todo>> GetTodosAsync(int id)
        => await GetDataAsync<Todo>($"{_url}users/{id}/todos");
    //получить фотографии
    public async Task<List<Photo>> GetPhotosAsync(int id)
        => await GetDataAsync<Photo>($"{_url}albums/{id}/photos");


    // получить данные асинхронно
    private async Task<List<T>> GetDataAsync<T>(string url = _url)
    {
        // асинхронная отправка запроса и ожидание ответа, в другом потоке
        HttpClient client = new HttpClient();
        HttpResponseMessage httpResponseMessage = await client.GetAsync(url);

        // чтение данных из ответа сервера - тоже асинхронно, в другом потоке 
        string content = await httpResponseMessage.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<List<T>>(content)!; 
    }
}

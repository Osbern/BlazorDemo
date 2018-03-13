using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using BlazorDemo.Models;

namespace BlazorDemo.Services
{
    public class BlogService : IBlogService
    {
        private HttpClient _http;

        public BlogService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IReadOnlyList<PostModel>> GetAllPostAsync()
        {
            var json = await _http.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            return JsonUtil.Deserialize<PostModel[]>(json);
        }
    }
}

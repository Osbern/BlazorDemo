using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Models;

namespace BlazorDemo.Services
{
    public interface IBlogService
    {
        Task<IReadOnlyList<PostModel>> GetAllPostAsync();
    }
}
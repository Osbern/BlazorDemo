using BlazorDemo.Services;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                // Add any custom services here
                configure.Add(ServiceDescriptor.Singleton<IBlogService, BlogService>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using WebApp.Models;

namespace WebApp.MiddleWares
{
    // Компонент middleware для инициализации базы данных
    public class InitializMiddleWare
    {
        private readonly RequestDelegate _next;

        public InitializMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, BaseparkingContext context)
        {
            DbInitializer.Initialize(context);
            return _next(httpContext);
        }
    }

    public static class DbInitializeExtensions
    {
        public static IApplicationBuilder UseDbInitializeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<InitializMiddleWare>();
        }
    }
}

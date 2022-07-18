using App.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace App.Extension
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder applicationBuidler)
        {
            return applicationBuidler.UseMiddleware<ExceptionHandlerMiddleware>();
        }

        public static IApplicationBuilder UseFileLogMiddleware(this IApplicationBuilder applicationBuidler)
        {
            return applicationBuidler.UseMiddleware<FileLogMiddleware>();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using App.Models;

namespace App.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next=next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (System.Exception e)
            {
                await context.Response.WriteAsJsonAsync(new ExceptionObject
                {
                    Code = context.Response.StatusCode,
                    Message = e.Message
                });
            }
        }

        
        
    }
}

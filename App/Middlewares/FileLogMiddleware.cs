using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace App.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FileLogMiddleware
    {
        private readonly RequestDelegate _next;

        public FileLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {

            string log=$"{DateTime.Now} => Method : {httpContext.Request.Method} StatusCode : {httpContext.Response.StatusCode}";
            File.AppendAllText("C:\\Users\\sandi\\OneDrive\\Masaüstü\\log.txt", log);
            await _next(httpContext);
        }
    }
}

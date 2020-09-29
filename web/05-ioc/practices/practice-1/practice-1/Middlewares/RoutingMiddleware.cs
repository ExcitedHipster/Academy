using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1.Middlewares
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ITimeService _timeService;


        public RoutingMiddleware(RequestDelegate next, ITimeService timeService)
        {
            _next = next;
            _timeService = timeService;
        }

        public async Task Invoke(HttpContext context)
        {

            Dictionary<string, string> routes = new Dictionary<string, string>
            {
                {"/",GetTime()},
            };

            var path = context.Request.Path.Value;

            if (routes.ContainsKey(path))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(routes[path]);
            }

          
        }

        private string GetTime()
        {
            return _timeService.GetTime();
        }

    }
}

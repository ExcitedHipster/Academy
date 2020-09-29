using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial_1.Middleware
{
    public class NumberMiddleware
    {
        private readonly RequestDelegate _next;

        public NumberMiddleware(RequestDelegate next)
        {
            _next = next;
        } 

        public async Task Invoke(HttpContext context)
        {
            var numberQuery = context.Request.Query.FirstOrDefault(x => x.Key == "number");

            var isNumberValid = int.TryParse(numberQuery.Value, out var number);

            if (isNumberValid && Enum.IsDefined(typeof(Numbers), number))
            {

                var result = (Numbers)number;

                Debug.WriteLine($"result: {result}");
            }

            await _next.Invoke(context);
        }
    }
}

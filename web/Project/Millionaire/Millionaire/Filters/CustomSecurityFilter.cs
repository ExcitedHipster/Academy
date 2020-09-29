using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Millionaire.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Filters {
    public class CustomSecurityFilter : IResourceFilter {
        private readonly IAuthService _authService;
        public CustomSecurityFilter(IAuthService authService) {
            _authService = authService;
        }
        public void OnResourceExecuting(ResourceExecutingContext context) {
            if (context.HttpContext.Request.Path.Value.Contains("Question"))
            {
                if (!context.HttpContext.Request.Path.Value.Contains("Login"))
                {
                    var token = string.Empty;
                    var cookieExists = context.HttpContext
                        .Request
                        .Cookies
                        .Any(x => x.Key == constants.TokenKey);
                    if (cookieExists)
                    {
                        token = context.HttpContext.Request.Cookies
                            .FirstOrDefault(x => x.Key == constants.TokenKey).Value;
                        if (string.IsNullOrWhiteSpace(token) || !_authService.isTokenValid(token))
                        {
                            context.Result = new RedirectResult("/Login/Index");
                        }
                    }
                    else context.Result = new RedirectResult("/Login/Index");

                }
            }

        }

        public void OnResourceExecuted(ResourceExecutedContext context) {

        }


    }
}

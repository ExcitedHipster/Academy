using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Practice_3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public static double answer=default;
        public static string input=default;
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

                bool isNumber = default;
            
            app.MapWhen((context) => isNumber=double.TryParse(input=context.Request.Query.FirstOrDefault(x => x.Key == "number").Value,out answer), Multiply);         
            app.MapWhen((context) => input!=null, validationMessage);
            app.Map("",Home);

        }

        private static void Multiply(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; \">answer is: {answer*=100}</ h1 > ");
            });
        }

        private static void validationMessage(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; \">input is not number</ h1 > ");
            });
        }

        private static void Home(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1 style=\"font - family:verdana; \">Multiply on 100 app</ h1 > ");
            });
        }

    }
}

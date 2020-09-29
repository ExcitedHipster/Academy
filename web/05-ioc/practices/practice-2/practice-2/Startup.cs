using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using practice_2.Services;


namespace practice_2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        static string menu1 = "1. Random string",menu2 = "2. Random negative number", menu3 = "3. Random positive number";
        public static RandomGenerator value = new RandomGenerator();
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IGenerator,RandomGenerator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        
            app.MapWhen((context) => context.Request.Query.FirstOrDefault(x => x.Key == "select").Value == "1", RandomString);
            app.MapWhen((context) => context.Request.Query.FirstOrDefault(x => x.Key == "select").Value == "2", RandomNegativeNumber);
            app.MapWhen((context) => context.Request.Query.FirstOrDefault(x => x.Key == "select").Value == "3", RandomPositiveNumber);
            app.Map("", Home);

        }

        private static void Home(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; \">Menu: </h1> <hr /> <h3>{menu1}</h3> <hr /> <h3>{menu2}</h3> <hr /> <h3>{menu3}</h3>" );
            });
        }
        private static void RandomString(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                Random rnd = new Random();
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; color: blue\">Random string: {value.GenerateString(rnd.Next(20))}</ h1 > <hr /> <h3>{menu1}</h3> <hr /> <h3>{menu2}</h3> <hr /> <h3>{menu3}</h3>" );
            });
        }

        private static void RandomPositiveNumber(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; color: blue\">Random positive number: {value.GeneratePositiveIntegerNumber()}</ h1 > <hr /> <h3>{menu1}</h3> <hr /> <h3>{menu2}</h3> <hr /> <h3>{menu3}</h3>");
            });
        }

        private static void RandomNegativeNumber(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<h1 style=\"font - family:verdana; color: blue\">Random negative number: {value.GenerateNegativeIntegerNumber()}</ h1 > <hr /> <h3>{menu1}</h3> <hr /> <h3>{menu2}</h3> <hr /> <h3>{menu3}</h3>");
            });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Tutorial_1
{
    public class Startup
    {
        private IServiceCollection _services;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _services = services;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(GetSetviceInfo());
                });
            });
        }

        private string GetSetviceInfo()
        {
            ServiceDescriptor service = _services.FirstOrDefault();

            var sBuilder = new StringBuilder();

            sBuilder.AppendLine($"Guid: {service.ServiceType.GUID}");
            sBuilder.AppendLine($"Namespace: {service.ServiceType.Namespace}");
            sBuilder.AppendLine($"Name: {service.ServiceType.Name}"); 
            sBuilder.AppendLine($"FullName: {service.ServiceType.FullName}");
            sBuilder.AppendLine($"Assembly.FullName: {service.ServiceType.Assembly.FullName}");
         

            return sBuilder.ToString();
        }
    }
}

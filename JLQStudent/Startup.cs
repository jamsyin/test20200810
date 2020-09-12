using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLQStudent.DataReposittories;
using JLQStudent.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 

namespace JLQStudent
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddDbContextPool<AppDbContext>(
                        options => options.UseSqlServer(_configuration.GetConnectionString("JLQStudentDBConnection")));
            services.AddControllersWithViews().AddXmlSerializerFormatters();
            // services.AddSingleton<IStudentRepository, JLQStudentRepository>();
            services.AddScoped<IStudentRepository, SQLStudentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
      
 

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
 
            });
            app.Run(async(context) =>
            {
                await context.Response.WriteAsync("Hi,�����?");

            });
            
        }
    }
}

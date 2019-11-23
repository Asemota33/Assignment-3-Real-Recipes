using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Comp229_301052117_Assign3.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Comp229_301052117_Assign3
{

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                Configuration["Data:Recipes:ConnectionString"]));
            services.AddTransient<IRecipeRepository, EFRecipesRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/");

                routes.MapRoute(
                    name: "",
                    template: "{controller=Crud}/{action=Review}/{dishName?}");

                routes.MapRoute(
                    name: "",
                    template: "{controller=Home}/{action=DisplayPage}/{dishName?}");
                //routes.MapRoute(
                //    name: "",
                //    template: "{controller=Crud}/{action=Review}/{dishName?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}

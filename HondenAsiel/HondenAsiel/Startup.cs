using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.Data.Mocks;
using Microsoft.Extensions.Configuration;
using HondenAsiel.Data;
using Microsoft.EntityFrameworkCore;
using HondenAsiel.Data.Repositories;
using HondenAsiel.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace HondenAsiel
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<IHondenRepo, HondenRepo>();
            services.AddTransient<IRasRepo, RasRepo>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => WinkelWagen.GetCart(sp));
            services.AddTransient<IOrderRepo, OrderRepo>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseSession();

#pragma warning disable CS0618 // Type or member is obsolete
            app.UseIdentity();
#pragma warning restore CS0618 // Type or member is obsolete

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "rasfilter", template: "Honden/{action}/{ras?}", defaults: new { Controller="Honden", action="HONDEN"});
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Honden}/{action=HONDEN}/{id?}");
            });

            
        }
    }
}

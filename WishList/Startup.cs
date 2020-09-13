using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WishList.Data;
namespace WishList
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
             services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Wishlist"));
        
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             if(env.IsDevelopment())
           {
               app.UseDeveloperExceptionPage();
           }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
           
            app.UseRouting();
            app.UseEndpoints(
                endpoints => { endpoints.MapDefaultControllerRoute(); }
            );
        }
    }
} 

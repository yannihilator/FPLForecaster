using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FPLForecaster
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Page}/{action=ManagerView}/{id?}");
            });
            
            var controller = new Controllers.DataController();
            controller.GetData();
            var test = DataService.Data.Players.GroupBy(x => x?.element_type);
            foreach (IGrouping<int?, Models.Player> group in test)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine(DataService.Enumerators.PlayerTypes.Where(x => x?.id == group.Key).FirstOrDefault()?.plural_name);
                Console.WriteLine("****************************************************************");
                foreach (Models.Player player in group.Where(y => y.total_points > 0).OrderByDescending(x => x?.total_points/x?.now_cost).ToList())
                {
                    Console.WriteLine($"{player.first_name} {player.second_name}: {player.total_points}");
                }
            }
        }
    }
}

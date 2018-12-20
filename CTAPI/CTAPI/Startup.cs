using CTAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace CTAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().AddControllersAsServices();
            services.AddMvc()
                  .AddJsonOptions(o =>
                  {
                      if (o.SerializerSettings.ContractResolver != null)
                      {
                          var castedResolver = o.SerializerSettings.ContractResolver
                                as DefaultContractResolver;
                          castedResolver.NamingStrategy = null;
                      }
                  });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //var connection = @"Server=jhassqlstg02.database.secure.windows.net,14412;Database=dbbtCalT;User ID=biztech;Password=B!$tech!123;";
            //var connection = @"Data Source=jhassqlstg02.database.windows.net;Initial Catalog=dbbtCalT;User ID=biztech;Password=B!$tech!123;";
            var connection = Configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<dbbtCalTContext>(options =>
            {
                options.UseSqlServer(connection);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            //try
            //{
            //    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            //    .CreateScope())
            //    {
            //        serviceScope.ServiceProvider.GetService<dbbtCalTContext>();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    System.Diagnostics.Debug.WriteLine(ex, "Failed to migrate or seed database");
            //}


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

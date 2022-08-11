using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Catalog.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Catalog.Services.Queries;
using MediatR;
using System.Reflection;
using Common.Logging;
using HealthChecks.UI.Client;

namespace Catalog.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext >
                (opts =>
            opts.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection"),
                x=>x.MigrationsHistoryTable("_EFMigrationsHistory","Catalog")
                )
            );

            

            services.AddMediatR(Assembly.Load("Catalog.Services.EventHandlers"));

            services.AddTransient<IProductQueryService, ProductQueryService>();
            services.AddTransient<IProductInStockQueryServices, ProductInStockQueryService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                
            }
            
            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShootingRange.Infrastructure.Data;

//using ShootingRange.Infrastructure;

namespace ShootingRange.Api
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
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName();
            var migrationsAssemblyName = migrationsAssembly.Name;

                        // ===== Add our DbContext ========
            services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseInMemoryDatabase("UniversityOnion"));
            options.UseSqlite("Filename=ShootingRange.db", b => b.MigrationsAssembly(migrationsAssemblyName)));
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(migrationsAssemblyName)));
            //options.UseMySql(Configuration.GetConnectionString("MysqlConnection")));
            //options.UseNpgsql(Configuration.GetConnectionString("PgsqlConnection")));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

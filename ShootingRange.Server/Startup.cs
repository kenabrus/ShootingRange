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
using Microsoft.OpenApi.Models;
using ShootingRange.Server.Data;
using Swashbuckle.AspNetCore.Swagger;

//using ShootingRange.Infrastructure;

namespace ShootingRange.Server
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
            //options.UseSqlite("Filename=ShootingRange.db", b => b.MigrationsAssembly(migrationsAssemblyName)));
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(migrationsAssemblyName)));
            //options.UseMySql(Configuration.GetConnectionString("MysqlConnection")));
            //options.UseNpgsql(Configuration.GetConnectionString("PgsqlConnection")));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "My API", 
                    Version = "v1" 
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
                    In = ParameterLocation.Header, 
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey 
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                { 
                    new OpenApiSecurityScheme 
                    { 
                    Reference = new OpenApiReference 
                    { 
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer" 
                    } 
                    },
                    new string[] { } 
                    } 
                });
            });

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

            //Cors policy (Angular, wasm)
            app.UseCors(x => x
                // .AllowAnyOrigin()
                // .WithOrigins("http://localhost:4200")
                .WithOrigins("http://localhost:5000")
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // ===== Initialize DB ======
            InitializeContactsData.InitializeAsync(app.ApplicationServices).Wait();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Serilog;
using Microsoft.AspNetCore;

using MatBlazor;



namespace ShootingRange.Client
{
    public class Program
    {
        public IConfiguration Configuration { get; }
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            // var configuration = new ConfigurationBuilder()
                
            //     .Build();

            // Log.Logger = new LoggerConfiguration()
            //     .ReadFrom.Configuration(configuration)
            //     .CreateLogger();

            builder.Services.AddLoadingBar();

            builder.Services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

            await builder
            .Build()
            //.UseLoadingBar()
            .RunAsync();
        }
    }
}

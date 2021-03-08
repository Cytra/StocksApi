using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.Shared;
using Stocks.UI.Services;

namespace Stocks.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddHttpClient<IUIStockService, IuiStockService>(client => client.BaseAddress = new Uri("https://localhost:5001"));
            builder.Services.AddHttpClient<IPortfolioProvider, PortfolioProvider>(client => client.BaseAddress = new Uri("https://localhost:5001"));
            await builder.Build().RunAsync();
        }
    }
}

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Stocks.Blazor.Services;
using Stocks.Model.Shared;

namespace Stocks.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<IUIStockService, IuiStockService>(client => client.BaseAddress = new Uri("https://localhost:5001"));
            builder.Services.AddHttpClient<IPortfolioProvider, PortfolioProvider>(client => client.BaseAddress = new Uri("https://localhost:5001"));
            builder.Services.AddHttpClient<IRedditOtherProvider, RedditOtherProvider>(client => client.BaseAddress = new Uri("https://localhost:5001"));
            builder.Services.AddHttpClient<IYahooFinanceOtherProvider, YahooFinanceOtherProvider>(client => client.BaseAddress = new Uri("https://localhost:5001"));

            await builder.Build().RunAsync();

            await builder.Build().RunAsync();
        }
    }
}

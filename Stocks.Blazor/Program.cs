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
            var apiUri = "https://localhost:5001";
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<IStockService, IuiStockService>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IPortfolioProvider, PortfolioProvider>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IRedditOtherProvider, RedditOtherProvider>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IYahooFinanceOtherProvider, YahooFinanceOtherProvider>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IStockPriceService, StockPriceService>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IStockScreenerPrivider, StockScreenerPrivider>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<ICalendarService, CalendarService>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IShortInterestProvider, ShortInterestProvider>(client => client.BaseAddress = new Uri(apiUri));
            builder.Services.AddHttpClient<IStockPriceProvider, StockPriceProvider>(client => client.BaseAddress = new Uri(apiUri));

            await builder.Build().RunAsync();
        }
    }
}

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Stocks.Blazor.Services;
using Stocks.Model.Shared;
using RedditOtherProvider = Stocks.Blazor.Services.RedditOtherProvider;
using ShortInterestProvider = Stocks.Blazor.Services.ShortInterestProvider;
using StockPriceProvider = Stocks.Blazor.Services.StockPriceProvider;
using StockScreenerPrivider = Stocks.Blazor.Services.StockScreenerPrivider;
using YahooFinanceOtherProvider = Stocks.Blazor.Services.YahooFinanceOtherProvider;

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
            builder.Services.AddHttpClient<IPtmProvider, PtmService>(client => client.BaseAddress = new Uri(apiUri));
            await builder.Build().RunAsync();
        }
    }
}

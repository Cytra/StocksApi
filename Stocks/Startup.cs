using System;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Serilog;
using Stocks.Core.Providers;
using Stocks.Core.Providers.Other;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Core.Queries;
using Stocks.Core.Scheduling;
using Stocks.Core.Services.Calendar;
using Stocks.Core.Services.DCF;
using Stocks.Core.Services.Dividend;
using Stocks.Core.Services.FinancialStatements;
using Stocks.Core.Services.Index;
using Stocks.Core.Services.Screener;
using Stocks.Core.Services.ShortInterest;
using Stocks.Core.Services.StockList;
using Stocks.Core.Services.StockPrice;
using Stocks.Core.Services.StockService;
using Stocks.Data.Contexts;
using Stocks.Data.Repositories;
using Stocks.Middleware;
using Stocks.Model;
using Stocks.Model.Shared;
using Swashbuckle.AspNetCore.Filters;

namespace Stocks
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public AppSettings AppSettings { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppSettings = configuration.GetSection("AppSettings").Get<AppSettings>();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.MicrosoftTeams(AppSettings.MsTeamsWebHook)
                .CreateLogger();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDcfProvider, DcfProvider>();
            services.AddScoped<IDCFService, DCFService>();
            services.AddScoped<IStocksRepository, StocksRepository>();
            services.AddScoped<IStockListService, StockListService>();
            services.AddScoped<IDividendProvider, DividendProvider>();
            services.AddScoped<IStockPriceProvider, StockPriceProvider>();
            services.AddScoped<IStockListService, StockListService>();
            services.AddScoped<IDividendCalendarService, DividendCalendarService>();
            services.AddScoped<IStockPriceService, StockPriceService>();
            services.AddScoped<ISPYconstituentService, SPYconstituentService>();
            services.AddScoped<ISPYconstituentProvider, SPYconstituentProvider>();
            services.AddScoped<IIncomeStatementService, IncomeStatementService>();
            services.AddScoped<IIncomeStatementProvider, IncomeStatementProvider>();
            services.AddScoped<IProfileProvider, ProfileProvider>();
            services.AddScoped<IBalanceSheetService, BalanceSheetService>();
            services.AddScoped<IBalanceSheetProvider, BalanceSheetProvider>();
            services.AddScoped<IPortfolioProvider, PortfolioProvider>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IStockScreenerService, StockScreenerService>();
            services.AddScoped<IStockScreenerPrivider, StockScreenerPrivider>();
            services.AddScoped<ICalendarService, CalendarService>();
            services.AddScoped<IShortInterestService, ShortInterestService>();
            services.AddScoped<IShortInterestProvider, ShortInterestProvider>();
            services.AddScoped<IPtmProvider, PtmProvider>();
            services.AddScoped<IShortSqueezeProvider, ShortSqueezeProvider>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddControllers()
                .AddNewtonsoftJson(opt =>
                {
                    opt.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;
                    opt.SerializerSettings.Formatting = Formatting.None;
                    opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    opt.SerializerSettings.Converters.Add(new StringEnumConverter());
                    JsonConvert.DefaultSettings = () => opt.SerializerSettings;
                });
            services.AddHttpClient("Stock", client =>
            {
                client.BaseAddress = new Uri("https://financialmodelingprep.com");
                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Clear();
            });

            services.AddHttpClient("yahooFinance", client =>
            {
                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Clear();
            });

            services.AddHttpClient("highInterest", client =>
            {
                client.BaseAddress = new Uri("https://highshortinterest.com");
                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Clear();
            });

            //services.AddMediatR(typeof(TStartup).Assembly);
            services.AddMediatR(typeof(StockPrice.Command).Assembly);

            services.AddOptions<AppSettings>().Bind(Configuration.GetSection("AppSettings"));

            services.AddCors(options => options.AddPolicy("AllowEverything", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));

            //'EnableRetryOnFailure
            services.AddDbContext<StocksContext>(options =>
            {
                options.UseSqlServer(AppSettings.SqlConnectionString,
                options => options.EnableRetryOnFailure());
                //options.UseSqlServer(AppSettings.SqlConnectionString);
                //options.EnableRetryOnFailure();
            });
            //services.AddDbContext<StocksContext>(options => options.UseInMemoryDatabase(AppSettings.SqlConnectionString));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.ExampleFilters();
            });
            services.AddSwaggerExamplesFromAssemblyOf<Startup>();

            services.AddCronJob<ShortSqueezeJob>(c =>
            {
                c.TimeZoneInfo = TimeZoneInfo.Local;
                c.CronExpression = AppSettings.ShortSqueezeCronExpression;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseCors("AllowEverything");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Neopay");
            });
        }
    }
}

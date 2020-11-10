using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stocks.Core.Providers;
using Stocks.Core.Services;
using Stocks.Data.Contexts;
using Stocks.Data.Repositories;
using Stocks.Middleware;
using Stocks.Model;
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
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDcfProvider, DcfProvider>();
            services.AddScoped<IStocksRepository, StocksRepository>();
            services.AddScoped<IStockService, StockService>();
            services.AddControllers();
            services.AddHttpClient("Stock", client =>
            {
                client.BaseAddress = new Uri("https://financialmodelingprep.com");
                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Clear();
            });

            services.AddOptions<AppSettings>().Bind(Configuration.GetSection("AppSettings"));

            services.AddDbContext<StocksContext>(options => options.UseSqlServer(AppSettings.SqlConnectionString));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.ExampleFilters();
            });
            services.AddSwaggerExamplesFromAssemblyOf<Startup>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();
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

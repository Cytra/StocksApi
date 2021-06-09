using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Stocks.Core.Providers.Other;

namespace Stocks.Core.Scheduling
{
    public class ShortSqueezeJob : CronJobService
    {
        private readonly ILogger<ShortSqueezeJob> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public ShortSqueezeJob(IScheduleConfig<ShortSqueezeJob> config, ILogger<ShortSqueezeJob> logger,
            IServiceScopeFactory scopeFactory)
            : base(config.CronExpression, config.TimeZoneInfo, logger, scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        protected override async Task DoWork(CancellationToken cancellationToken)
        {
            try
            {
                using var scope = _scopeFactory.CreateScope();
                var shortSqueezeProvider = scope.ServiceProvider.GetRequiredService<IShortSqueezeProvider>();
                await shortSqueezeProvider.GetShortStocksAndNotify();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error when getting Short Squeeze stocks");
            }
        }
    }
}

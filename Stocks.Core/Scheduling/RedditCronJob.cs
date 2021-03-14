using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Stocks.Core.Providers.SaveToDbProviders;
using Stocks.Model.Reddit;

namespace Stocks.Core.Scheduling
{
    public class RedditCronJob : CronJobService
    {
        private readonly ILogger<RedditCronJob> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public RedditCronJob(IScheduleConfig<RedditCronJob> config, ILogger<RedditCronJob> logger,
            IServiceScopeFactory scopeFactory)
            : base(config.CronExpression, config.TimeZoneInfo, logger, scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        protected override async Task DoWork(CancellationToken cancellationToken)
        {
            using var scope = _scopeFactory.CreateScope();
            var redditDBProvider = scope.ServiceProvider.GetRequiredService<IRedditDBProvider>();
            await redditDBProvider.GetDdList(new RedditDbRequest()
            {
                SortType = RedditSortType.hour
            });
        }
    }
}

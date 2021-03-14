using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cronos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Timer = System.Timers.Timer;

namespace Stocks.Core.Scheduling
{
    public abstract class CronJobService : IHostedService, IDisposable
    {
        private readonly CronExpression _expression;
        private readonly ILogger _logger;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly TimeZoneInfo _timeZoneInfo;
        private Timer _timer;

        protected CronJobService(string cronExpression, TimeZoneInfo timeZoneInfo,
            ILogger logger, IServiceScopeFactory scopeFactory)
        {
            _expression = CronExpression.Parse(cronExpression, CronFormat.IncludeSeconds);
            _timeZoneInfo = timeZoneInfo;
            _logger = logger;
            _scopeFactory = scopeFactory;
            LockKey = GetType().FullName;
        }

        private string LockKey { get; }

        public virtual Task StartAsync(CancellationToken cancellationToken)
        {
            return ScheduleJob(cancellationToken);
        }

        public virtual Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Stop();
            return Task.CompletedTask;
        }

        protected abstract Task DoWork(CancellationToken cancellationToken);

        private async Task DoLockedWork(CancellationToken cancellationToken)
        {
            using var scope = _scopeFactory.CreateScope();
            await DoWork(cancellationToken);
            //using var @lock = await scope.ServiceProvider.GetRequiredService<IDistributedResourceLockService>()
            //    .TryAcquireLockAsync(LockKey, TimeSpan.FromSeconds(5), cancellationToken);
            //if (@lock != null)
            //{
            //    await DoWork(cancellationToken);
            //}
        }

        private DateTimeOffset? GetNextTrigger()
        {
            var next = _expression.GetNextOccurrence(DateTimeOffset.Now, _timeZoneInfo);
            return next;
        }

        private Task ScheduleJob(CancellationToken cancellationToken)
        {
            var next = GetNextTrigger();
            if (next.HasValue)
            {
                var delay = next.Value - DateTimeOffset.Now;
                _timer = new Timer(delay.TotalMilliseconds);
                _timer.Elapsed += async (sender, args) =>
                {
                    _timer.Dispose(); // reset and dispose timer
                    _timer = null;

                    if (!cancellationToken.IsCancellationRequested)
                    {
                        try
                        {
                            await DoLockedWork(cancellationToken);
                        }
                        catch (Exception ex)
                        {
                            _logger?.LogCritical(ex, ex.Message);
                        }
                    }

                    if (!cancellationToken.IsCancellationRequested)
                    {
                        await ScheduleJob(cancellationToken); // reschedule next
                    }
                };
                _timer.Start();
            }

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}

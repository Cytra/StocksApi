using System;

namespace Stocks.Core.Scheduling
{
    public class ScheduleConfig<T> : IScheduleConfig<T>
    {
        public string CronExpression { get; set; }

        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
}

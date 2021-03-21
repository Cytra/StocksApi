using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stocks.Core.Helpers
{
    public static class DateHelper
    {
        public static string GetDateStringFromUnix(float unix)
        {
            var datetime = DateTimeOffset.FromUnixTimeSeconds((long)unix);
            var nowDatetime = DateTimeOffset.Now;
            var dif = nowDatetime - datetime;
            if (dif.TotalHours <= 1)
            {
                return $"{dif:mm} min";
            }
            if (dif.TotalHours <= 24)
            {
                return $"{dif:hh} hours";
            }
            else if (dif.TotalDays <= 365)
            {
                return $"{dif:dd} days";
            }
            else
            {
                return "";
            }
        }
    }
}

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
                return "1H";
            }
            else if (dif.TotalHours <= 5)
            {
                return "5H";
            }
            else if (dif.TotalHours <= 10)
            {
                return "10H";
            }
            else if (dif.TotalHours <= 20)
            {
                return "20H";
            }
            else if (dif.TotalDays <= 1)
            {
                return "1D";
            }
            else if (dif.TotalDays <= 2)
            {
                return "2D";
            }
            else if (dif.TotalDays <= 3)
            {
                return "3D";
            }
            else if (dif.TotalDays <= 4)
            {
                return "4D";
            }
            else if (dif.TotalDays <= 5)
            {
                return "5D";
            }
            else if (dif.TotalDays <= 10)
            {
                return "10D";
            }
            else if (dif.TotalDays <= 20)
            {
                return "20D";
            }
            else if (dif.TotalDays <= 30 * 1)
            {
                return "1M";
            }
            else if (dif.TotalDays <= 30 * 2)
            {
                return "2M";
            }
            else if (dif.TotalDays <= 30 * 3)
            {
                return "3M";
            }
            else
            {
                return "";
            }
        }
    }
}

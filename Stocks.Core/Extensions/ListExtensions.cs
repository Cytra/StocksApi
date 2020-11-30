using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks.Core.Extensions
{
    public static class ListExtensions
    {
        public static List<List<T>> Split<T>(List<T> source, int count)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / count)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}

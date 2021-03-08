using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks.Core.Extensions
{
    public static class StringExtensions
    {
        public static string GetSymbolsString(string[] ids)
        {
            var idsStringBuilder = new StringBuilder();
            for (int i = 0; i < ids.Count() - 1; i++)
            {
                idsStringBuilder.Append(ids[i]);
                idsStringBuilder.Append(',');
            }
            idsStringBuilder.Append(ids[ids.Count() - 1]);
            var result = idsStringBuilder.ToString().Replace("/", "");
            return result;
        }

        public static string GetSymbolsString(List<string> ids)
        {
            var idsStringBuilder = new StringBuilder();
            for (int i = 0; i < ids.Count() - 1; i++)
            {
                idsStringBuilder.Append(ids[i]);
                idsStringBuilder.Append(',');
            }
            idsStringBuilder.Append(ids[ids.Count() - 1]);
            var result = idsStringBuilder.ToString().Replace("/", "");
            return result;
        }
    }
}

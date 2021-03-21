using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Stocks.Model.YahooFinance;

namespace Stocks.Model.Shared
{
    public interface IYahooFinanceOtherProvider
    {
        Task<List<YahooFinanceOptionEntityGroupBy>> GetOpenInterest(string ticker);
        Task<List<string>> GetOpenInterestStockList();
    }
}

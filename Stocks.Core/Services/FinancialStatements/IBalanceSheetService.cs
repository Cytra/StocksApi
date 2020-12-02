using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.FinancialStatements;

namespace Stocks.Core.Services.FinancialStatements
{
    public interface IBalanceSheetService
    {
        Task<List<BalanceSheet>> GetBalanceSheets(string symbol);
    }
}

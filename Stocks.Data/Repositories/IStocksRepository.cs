using Stocks.Data.Entities.DCF;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Entities.Index;
using Stocks.Data.Entities.StockPrice;

namespace Stocks.Data.Repositories
{
    public interface IStocksRepository
    {
        Task SaveDCFs(List<Historical_discounted_cash_flow_Entity> dcfs);
        Task DeleteDCF(string stock);
        Task SaveDividendCalendarEntities(List<DividendCalendarEntity> input);
        Task DeleteAllDividendCalendarEntities();
        Task SaveDividendCalendarEntity(DividendCalendarEntity input);
        Task DeleteAllStockPriceHistoricEntities();
        Task SaveStockPriceHistoricEntities(List<StockPriceHistoricEntity> entities);
        Task DeleteSPYconstituentEntities();
        Task SaveSPYconstituentEntities(List<SPYconstituentEntity> entities);
        Task DeleteIncomeStatementEntities();
        Task SaveIncomeStatementEntities(List<IncomeStatementEntity> entities);
    }
}

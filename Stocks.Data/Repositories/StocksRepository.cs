using Stocks.Data.Contexts;
using Stocks.Data.Entities.DCF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities.Dividend;

namespace Stocks.Data.Repositories
{
    public class StocksRepository : IStocksRepository
    {
        private readonly StocksContext _stocksContext;
        public StocksRepository(StocksContext stocksContext)
        {
            _stocksContext = stocksContext;
        }

        public async Task DeleteDCF(string stock)
        {
            var dcfs = _stocksContext.DCFs.Where(x => x.Symbol == stock).ToList();
            _stocksContext.RemoveRange(dcfs);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task SaveDividendCalendarEntities(List<DividendCalendarEntity> input)
        {
            await _stocksContext.BulkInsertAsync(input);
        }

        public async Task DeleteAllDividendCalendarEntities()
        {
            var dividends = await _stocksContext.DividendCalendarEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(dividends);
        }

        public async Task SaveDividendCalendarEntity(DividendCalendarEntity input)
        {
            _stocksContext.DividendCalendarEntities.Add(input);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task SaveDCFs(List<Historical_discounted_cash_flow_Entity> dcfs)
        {
            _stocksContext.DCFs.AddRange(dcfs);
            await _stocksContext.SaveChangesAsync();
        }
    }
}

using System;
using Stocks.Data.Contexts;
using Stocks.Data.Entities.DCF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Entities.Index;
using Stocks.Data.Entities.Portfolio;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Entities.Reddit;
using Stocks.Data.Entities.StockPrice;
using Stocks.Data.Entities.YahooFinance;
using Stocks.Model.Reddit;
using Stocks.Model.YahooFinance;

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

        public async Task DeleteAllStockPriceHistoricEntities()
        {
            var entities = await _stocksContext.StockPriceHistoricEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveStockPriceHistoricEntities(List<StockPriceHistoricEntity> entities)
        {
            _stocksContext.StockPriceHistoricEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task DeleteSPYconstituentEntities()
        {
            var entities = await _stocksContext.SPYconstituentEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveSPYconstituentEntities(List<SPYconstituentEntity> entities)
        {
            _stocksContext.SPYconstituentEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task DeleteIncomeStatementEntities()
        {
            var entities = await _stocksContext.IncomeStatementEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveIncomeStatementEntities(List<IncomeStatementEntity> entities)
        {
            _stocksContext.IncomeStatementEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task DeleteStockProfileEntities()
        {
            var entities = await _stocksContext.StockProfileEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveStockProfileEntities(List<StockProfileEntity> entities)
        {
            _stocksContext.StockProfileEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task DeleteBalanceSheetEntities()
        {
            var entities = await _stocksContext.BalanceSheetEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveBalanceSheetEntities(List<BalanceSheetEntity> entities)
        {
            _stocksContext.BalanceSheetEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task SaveDividendCalendarEntities2(List<DividendCalendarEntity2> entities)
        {
            await _stocksContext.BulkInsertAsync(entities);
        }

        public async Task DeleteAllDividendCalendarEntities2()
        {
            var dividends = await _stocksContext.DividendCalendarEntities2.ToListAsync();
            await _stocksContext.BulkDeleteAsync(dividends);
        }

        public async Task DeleteStockPriceEntities()
        {
            var entities = await _stocksContext.StockPriceEntities.ToListAsync();
            await _stocksContext.BulkDeleteAsync(entities);
        }

        public async Task SaveStockPriceEntities(List<StockPriceEntity> entities)
        {
            _stocksContext.StockPriceEntities.AddRange(entities);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task DeletePortfolioItem(Guid stockId)
        {
            var dbItem = _stocksContext.Portfolio.Single(x => x.StockId == stockId);
            dbItem.Deleted = DateTimeOffset.Now;
            await _stocksContext.SaveChangesAsync();
        }

        public async Task AddStockItem(PortfolioEntity dbItem)
        {
            _stocksContext.Portfolio.Add(dbItem);
            await _stocksContext.SaveChangesAsync();
        }

        public async Task<List<PortfolioEntity>> GetPortfolio(bool withDeleted)
        {
            var query = _stocksContext.Portfolio.AsNoTracking();
            if (withDeleted)
            {
                
            }
            else
            {
                query = query.Where(x => x.Deleted == null);
            }
            return await query.ToListAsync();
        }

        public async Task SaveRedditDdEntities(List<RedditDdEntity> result, float from, float to)
        {
            var existingDbs = _stocksContext.RedditDdEntities
                .Where(x => x.created_utc >= from && x.created_utc <= to).ToList();
            await _stocksContext.BulkDeleteAsync(existingDbs);
            await _stocksContext.BulkInsertAsync(result);
        }

        public async Task<List<RedditDdEntity>> GetRedditDdEntities(RedditOtherRequest request)
        {
            var result = await _stocksContext.RedditDdEntities
                .Where(x => x.created_utc >= request.DateFrom.ToUnixTimeSeconds() 
                            && x.created_utc <= request.DateTo.ToUnixTimeSeconds()
                            && x.score > 0
                            ).ToListAsync();
            return result;
        }

        public async Task<RedditDdEntity> GetRedditDdEntity(int id)
        {
            var result = await _stocksContext.RedditDdEntities
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task SaveYahooFinanceOptionEntities(List<YahooFinanceOptionEntity> entities)
        {
            var existing = await _stocksContext.YahooFinanceOptionEntities
                .Where(x => x.Created.Date == DateTimeOffset.Now.Date 
                            && entities.Select(y=> y.Ticker).Contains(x.Ticker))
                .ToListAsync();

            var toUpdateEntities = new List<YahooFinanceOptionEntity>();
            var toInsertEntities = new List<YahooFinanceOptionEntity>();
            foreach (var entity in entities)
            {
                var toUpdate = existing.SingleOrDefault(x => x.OptionName == entity.OptionName);
                if (toUpdate != null)
                {
                    toUpdate.OpenInterest = entity.OpenInterest;
                    toUpdate.StrikePrice = entity.StrikePrice;
                    toUpdateEntities.Add(toUpdate);
                }
                else
                {
                    toInsertEntities.Add(entity);
                }
            }

            await _stocksContext.BulkInsertAsync(toInsertEntities);
            await _stocksContext.BulkUpdateAsync(toUpdateEntities);
        }

        public async Task<List<YahooFinanceOptionEntityGroupByItem>> GetYahooFinanceOptionEntities(string ticker)
        {
            var query = await _stocksContext.Set<YahooFinanceOptionEntity>()
                .Where(tik => tik.Ticker == ticker)
                .GroupBy(c => new { c.Created.Date, c.Type, }, (k, g) => new
                {
                    OpenInterest = g.Sum(b => b.OpenInterest),
                    Created = k.Date,
                    Type = k.Type
                }).Select(h => new YahooFinanceOptionEntityGroupByItem()
                {
                    Created = h.Created,
                    OpenInterest = h.OpenInterest,
                    Type = h.Type
                }).ToListAsync();

            return query;
        }

        public async Task SaveDCFs(List<Historical_discounted_cash_flow_Entity> dcfs)
        {
            _stocksContext.DCFs.AddRange(dcfs);
            await _stocksContext.SaveChangesAsync();
        }
    }
}

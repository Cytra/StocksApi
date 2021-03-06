﻿using System;
using Stocks.Data.Entities.DCF;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        Task DeleteStockProfileEntities();
        Task SaveStockProfileEntities(List<StockProfileEntity> entities);
        Task DeleteBalanceSheetEntities();
        Task SaveBalanceSheetEntities(List<BalanceSheetEntity> entities);
        Task SaveDividendCalendarEntities2(List<DividendCalendarEntity2> entities);
        Task DeleteAllDividendCalendarEntities2();
        Task DeleteStockPriceEntities();
        Task SaveStockPriceEntities(List<StockPriceEntity> entities);
        Task DeletePortfolioItem(Guid stockId);
        Task AddStockItem(PortfolioEntity dbItem);
        Task<List<PortfolioEntity>> GetPortfolio(bool withDeleted);
        Task SaveRedditDdEntities(List<RedditDdEntity> result, float from, float to);
        Task<List<RedditDdEntity>> GetRedditDdEntities(RedditOtherRequest request);
        Task<RedditDdEntity> GetRedditDdEntity(int id);
        Task SaveYahooFinanceOptionEntities(List<YahooFinanceOptionEntity> entities);
        Task<List<YahooFinanceOptionEntityGroupByItem>> GetYahooFinanceOptionEntities(string ticker);
    }
}

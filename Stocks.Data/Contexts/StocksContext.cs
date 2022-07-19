using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities;
using Stocks.Data.Entities.DCF;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Entities.Index;
using Stocks.Data.Entities.Portfolio;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Entities.StockPrice;

namespace Stocks.Data.Contexts
{
    public class StocksContext : DbContext
    {
        public StocksContext(DbContextOptions<StocksContext> options) : base(options)
        {
        }

        public DbSet<Historical_discounted_cash_flow_Entity> DCFs { get; set; }
        public DbSet<DividendCalendarEntity> DividendCalendarEntities { get; set; }
        public DbSet<DividendCalendarEntity2> DividendCalendarEntities2 { get; set; }
        public DbSet<StockPriceHistoricEntity> StockPriceHistoricEntities { get; set; }
        public DbSet<SPYconstituentEntity> SPYconstituentEntities { get; set; }
        public DbSet<IncomeStatementEntity> IncomeStatementEntities { get; set; }
        public DbSet<StockProfileEntity> StockProfileEntities { get; set; }
        public DbSet<BalanceSheetEntity> BalanceSheetEntities { get; set; }
        public DbSet<StockPriceEntity> StockPriceEntities { get; set; }
        public DbSet<PortfolioEntity> Portfolio { get; set; }
    }
}

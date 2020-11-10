using Microsoft.EntityFrameworkCore;
using Stocks.Data.Entities.DCF;

namespace Stocks.Data.Contexts
{
    public class StocksContext : DbContext
    {
        public StocksContext(DbContextOptions<StocksContext> options) : base(options)
        {
        }

        public DbSet<Historical_discounted_cash_flow_Entity> DCFs { get; set; }

    }
}

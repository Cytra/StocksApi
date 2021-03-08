using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stocks.Model.Portfolio;

namespace Stocks.Model.Shared
{
    public interface IPortfolioProvider
    {
        Task<List<PortfolioItem>> AllPortfolio(bool withDeleted);
        Task AddStock(PortfolioRequest request);
        Task DeleteStock(Guid stockId);
    }
}

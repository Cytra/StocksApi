using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Stocks.Data.Entities;
using Stocks.Data.Repositories;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.Other
{
    public class ShortSqueezeProvider : IShortSqueezeProvider
    {
        private readonly ILogger<ShortInterestProvider> _logger;
        private readonly IShortInterestProvider _shortInterestProvider;
        private readonly IGenericRepository<ShortSqueezeNotifications> _repo;
        public ShortSqueezeProvider(
            ILogger<ShortInterestProvider> logger,
            IShortInterestProvider shortInterestProvider,
            IGenericRepository<ShortSqueezeNotifications> repo)
        {
            _logger = logger;
            _shortInterestProvider = shortInterestProvider;
            _repo = repo;
        }
        public async Task GetShortStocksAndNotify()
        {
            var shortInterestStocks = await _shortInterestProvider.GetShortInterestList();
            var alreadyNotifiedStocks = await _repo.Get(x => x.Created.Date == DateTime.Today);

            for (decimal i = 0.5m; i >= 0.1m; i -= 0.1m)
            {
                foreach (var shortInterestStock in shortInterestStocks)
                {
                    var dbInstance = alreadyNotifiedStocks
                        .OrderByDescending(x => x.Limit)
                        .FirstOrDefault(x => x.Symbol == shortInterestStock.Ticker && x.Limit >= i);
                    if (shortInterestStock.Prices.Day.Performance >= i && dbInstance == null)
                    {
                        _logger.LogWarning($"Stock - {shortInterestStock.Ticker}; Reached ratio - {shortInterestStock.Prices.Day.Performance * 100}%; Limit {i*100}");
                        await _repo.Insert(new ShortSqueezeNotifications()
                        {
                            Created = DateTimeOffset.Now,
                            Limit = i,
                            Symbol = shortInterestStock.Ticker
                        }, true);
                    }
                }
            }
        }
    }

    public interface IShortSqueezeProvider
    {
        Task GetShortStocksAndNotify();
    }
}

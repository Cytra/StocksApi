using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Providers.Other;
using Stocks.Data.Entities.Portfolio;
using Stocks.Data.Repositories;
using Stocks.Model.Portfolio;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers
{

    public class PortfolioProvider : IPortfolioProvider
    {
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        private readonly IStockPriceProvider _stockPriceProvider;
        public PortfolioProvider(
            IStocksRepository stocksRepository, 
            IMapper mapper,
            IStockPriceProvider stockPriceProvider)
        {
            _stocksRepository = stocksRepository;
            _mapper = mapper;
            _stockPriceProvider = stockPriceProvider;
        }

        public async Task<List<PortfolioItem>> AllPortfolio(bool withDeleted)
        {
            var dbItems = await _stocksRepository.GetPortfolio(withDeleted);
            var result = _mapper.Map<List<PortfolioItem>>(dbItems);
            var prices = await _stockPriceProvider.GetStockPrices(dbItems.Select(x=> x.Ticker).ToList());
            foreach (var item in result)
            {
                var price = prices.SingleOrDefault(x => x.Symbol == item.Ticker);
                if (price != null)
                {
                    item.CurrentPrice = price.Price;
                    item.Change = (price.Price / item.BuyPrice - 1).ToString("0.##");
                }
            }
            return result;
        }

        public async Task AddStock(PortfolioRequest request)
        {
            var dbItem = _mapper.Map<PortfolioEntity>(request);
            dbItem.StockId = Guid.NewGuid();
            dbItem.Created = DateTimeOffset.Now;
            await _stocksRepository.AddStockItem(dbItem);
        }

        public async Task DeleteStock(Guid stockId)
        {
            await _stocksRepository.DeletePortfolioItem(stockId);
        }
    }
}

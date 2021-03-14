using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.StockPrice;
using Stocks.Data.Repositories;
using Stocks.Model;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.Other
{
    public class RedditOtherProvider : IRedditOtherProvider
    {
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        private readonly IStockPriceProvider _stockPriceProvider;

        public RedditOtherProvider(IStocksRepository stocksRepository, IMapper mapper, IStockPriceProvider stockPriceProvider)
        {
            _stocksRepository = stocksRepository;
            _mapper = mapper;
            _stockPriceProvider = stockPriceProvider;
        }

        public async Task<RedditDdDtoList> GetDdList(RedditOtherRequest request)
        {
            var entities = await _stocksRepository.GetRedditDdEntities(request);
            var result = _mapper.Map<List<RedditDdDto>>(entities);
            await _stockPriceProvider.GetStockPricesForUi(result);
            return new RedditDdDtoList()
            {
                Items = result,
                Paging = new PagingModel()
                {
                    Page = request.Page,
                    PageSize = request.RowsPerPage,
                    TotalItems = result.Count
                }
            };
        }
    }
}

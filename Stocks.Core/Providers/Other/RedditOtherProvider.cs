using AutoMapper;
using Stocks.Data.Repositories;
using Stocks.Model;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            var dtos = _mapper.Map<List<RedditDdDto>>(entities);
            var ddDtoList = await _stockPriceProvider.GetStockPricesForUi(dtos, request);
            return ddDtoList;
        }

        public async Task<RedditDdDto> GetDbItem(int id)
        {
            var entity = await _stocksRepository.GetRedditDdEntity(id);
            if (entity != null)
            {
                var result = _mapper.Map<RedditDdDto>(entity);
                return result;
            }

            return null;
        }
    }
}

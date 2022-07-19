using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Repositories;
using Stocks.Model.FMP.Profile;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IProfileProvider
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
    public class ProfileProvider : IProfileProvider
    {
        private readonly IStockService _stockService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public ProfileProvider(IStockService stockService, IStocksRepository stocksRepository, IMapper mapper)
        {
            _stockService = stockService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var result = await _stockService.GetStockProfile(symbol);
            var dbEntities = _mapper.Map<List<StockProfileEntity>>(result);
            await _stocksRepository.SaveStockProfileEntities(dbEntities);
            return result;
        }
    }
}

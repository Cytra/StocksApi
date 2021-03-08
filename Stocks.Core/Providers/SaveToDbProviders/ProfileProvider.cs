using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.Profile;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Repositories;
using Stocks.Model.Profile;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IProfileProvider
    {
        Task<List<StockProfile>> GetStockProfile(string symbol);
    }
    public class ProfileProvider : IProfileProvider
    {
        private readonly IProfileService _profileService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public ProfileProvider(IProfileService profileService, IStocksRepository stocksRepository, IMapper mapper)
        {
            _profileService = profileService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task<List<StockProfile>> GetStockProfile(string symbol)
        {
            var result = await _profileService.GetStockProfile(symbol);
            var dbEntities = _mapper.Map<List<StockProfileEntity>>(result);
            await _stocksRepository.SaveStockProfileEntities(dbEntities);
            return result;
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.Index;
using Stocks.Data.Entities.Index;
using Stocks.Data.Repositories;
using Stocks.Model.Fmp.Index;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface ISPYconstituentProvider
    {
        Task<List<SPYconstituentModel>> GetSpyHistory();
    }
    public class SPYconstituentProvider : ISPYconstituentProvider
    {
        private readonly ISPYconstituentService _SPYconstituentService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public SPYconstituentProvider(ISPYconstituentService spYconstituentService, IStocksRepository stocksRepository, IMapper mapper)
        {
            _SPYconstituentService = spYconstituentService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task<List<SPYconstituentModel>> GetSpyHistory()
        {
            await _stocksRepository.DeleteSPYconstituentEntities();
            var historyItems = await _SPYconstituentService.GetSpyAddedHistory();
            var dbEntities = _mapper.Map<List<SPYconstituentEntity>>(historyItems);
            await _stocksRepository.SaveSPYconstituentEntities(dbEntities);
            return historyItems;
        }
    }
}

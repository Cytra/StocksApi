using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.FinancialStatements;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Repositories;
using Stocks.Model.Fmp.FinancialStatements;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IIncomeStatementProvider
    {
        Task<List<IncomeStatement>> GetIncomeStatements(string symbol);
    }
    public class IncomeStatementProvider : IIncomeStatementProvider
    {
        private readonly IIncomeStatementService _incomeStatementService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public IncomeStatementProvider(IIncomeStatementService incomeStatementService, IStocksRepository stocksRepository, IMapper mapper)
        {
            _incomeStatementService = incomeStatementService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task<List<IncomeStatement>> GetIncomeStatements(string symbol)
        {
            var result = await _incomeStatementService.GetIncomeStatements(symbol);
            var dbEntities = _mapper.Map<List<IncomeStatementEntity>>(result);
            await _stocksRepository.SaveIncomeStatementEntities(dbEntities);
            return result;
        }
    }
}

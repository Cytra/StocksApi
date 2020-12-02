using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Stocks.Core.Services.FinancialStatements;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Repositories;
using Stocks.Model.FinancialStatements;

namespace Stocks.Core.Providers
{
    public class BalanceSheetProvider : IBalanceSheetProvider
    {
        private readonly IBalanceSheetService _balanceSheetService;
        private readonly IStocksRepository _stocksRepository;
        private readonly IMapper _mapper;
        public BalanceSheetProvider(
            IBalanceSheetService balanceSheetService, 
            IStocksRepository stocksRepository, 
            IMapper mapper)
        {
            _balanceSheetService = balanceSheetService;
            _stocksRepository = stocksRepository;
            _mapper = mapper;
        }

        public async Task<List<BalanceSheet>> GetBalanceSheets(string symbol)
        {
            var result = await _balanceSheetService.GetBalanceSheets(symbol);
            var dbEntities = _mapper.Map<List<BalanceSheetEntity>>(result);
            await _stocksRepository.SaveBalanceSheetEntities(dbEntities);
            return result;
        }
    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Providers.SaveToDbProviders;

namespace Stocks.Controllers.Fmp
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FinancialStatementsController : ControllerBase
    {
        private readonly IIncomeStatementProvider _incomeStatementProvider;
        public FinancialStatementsController(IIncomeStatementProvider incomeStatementProvider)
        {
            _incomeStatementProvider = incomeStatementProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetIncomeStatement(string symbol)
        {
            var result = await _incomeStatementProvider.GetIncomeStatements(symbol);
            return Ok(result);
        }
    }
}

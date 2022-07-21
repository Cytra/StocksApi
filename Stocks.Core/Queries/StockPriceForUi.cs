using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Stocks.Model.Fmp.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Core.Queries;

public static class StockPriceForUi
{
    public class Command : IRequest<List<StockPricesForUi>>
    {
        public List<string> Tickers { get; set; }
    }

    public class Handler : IRequestHandler<Command, List<StockPricesForUi>>
    {
        private readonly ILogger<Handler> _logger;
        private readonly IStockPriceProvider _stockPriceProvider;

        public Handler(ILogger<Handler> logger,
            IStockPriceProvider stockPriceProvider)
        {
            _logger = logger;
            _stockPriceProvider = stockPriceProvider;
        }

        public async Task<List<StockPricesForUi>> Handle(Command request, CancellationToken cancellationToken)
        {
            _logger.LogDebug($"Trying to get stock prices for UI for {request.Tickers}");
            var input = new StockPricesForUiRequest()
            {
                Tickers = request.Tickers
            };
            var result = await _stockPriceProvider.GetPricesForUi(input);
            return result;
        }
    }
}

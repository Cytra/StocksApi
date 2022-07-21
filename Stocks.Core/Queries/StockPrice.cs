using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Stocks.Model.Fmp.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Core.Queries;

public static class StockPrice
{
    public class Command : IRequest<StockPriceHistoric>
    {
        public string Ticket { get; set; }
    }

    public class Handler : IRequestHandler<Command, StockPriceHistoric>
    {
        private readonly ILogger<Handler> _logger;
        private readonly IStockPriceService _stockPriceService;

        public Handler(ILogger<Handler> logger,
            IStockPriceService stockPriceService)
        {
            _logger = logger;
            _stockPriceService = stockPriceService;
        }

        public async Task<StockPriceHistoric> Handle(Command request, CancellationToken cancellationToken)
        {
            _logger.LogDebug($"Trying to get stock prices for {request.Ticket}");
            var result = await _stockPriceService.GetHistoricPrices(request.Ticket);
            return result;
        }
    }
}
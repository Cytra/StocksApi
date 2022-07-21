using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Stocks.Core.Queries;
using Stocks.Model.Fmp.StockPrice;
using StockPriceForUi = Stocks.Core.Queries.StockPriceForUi;

namespace Stocks.Controllers.Fmp;

[ApiController]
[Route("api/[controller]/[action]")]
public class PriceController : ControllerBase
{
    private readonly IMediator _mediator;

    public PriceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> StockPrice(string ticker)
    {
        var response = await _mediator.Send(
            new StockPrice.Command(){ Ticket = ticker});
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> StockPriceForUi(StockPricesForUiRequest request)
    {
        var response = await _mediator.Send(
            new StockPriceForUi.Command() { Tickers = request.Tickers});
        return Ok(response);
    }
}
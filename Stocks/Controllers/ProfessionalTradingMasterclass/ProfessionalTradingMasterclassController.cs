using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocks.Model.Fmp.Calendar;
using Stocks.Model.Shared;

namespace Stocks.Controllers.ProfessionalTradingMasterclass;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProfessionalTradingMasterclassController : ControllerBase
{
    private readonly IPtmProvider _ptmProvider;

    public ProfessionalTradingMasterclassController(IPtmProvider ptmProvider)
    {
        _ptmProvider = ptmProvider;
    }

    [HttpPost]
    public async Task<IActionResult> IsmPmisManufacturing(CalendarRequest request)
    {
        var result = await _ptmProvider.GetIsmPmisManufacturing(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> IsmPmisServices(CalendarRequest request)
    {
        var result = await _ptmProvider.GetIsmPmisServices(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> ConsumerSentimentMichigan(CalendarRequest request)
    {
        var result = await _ptmProvider.ConsumerSentimentMichigan(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> BuildingPermits(CalendarRequest request)
    {
        var result = await _ptmProvider.BuildingPermits(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> NonfarmPayrolls(CalendarRequest request)
    {
        var result = await _ptmProvider.NonfarmPayrolls(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> UnemploymentRate(CalendarRequest request)
    {
        var result = await _ptmProvider.UnemploymentRate(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> DurableGoods(CalendarRequest request)
    {
        var result = await _ptmProvider.DurableGoods(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Gdp(CalendarRequest request)
    {
        var result = await _ptmProvider.Gdp(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> UnemploymentRateCH(CalendarRequest request)
    {
        var result = await _ptmProvider.UnemploymentRateCH(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PmiCH(CalendarRequest request)
    {
        var result = await _ptmProvider.PmiCH(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> GdpCH(CalendarRequest request)
    {
        var result = await _ptmProvider.GdpCH(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> LeadingIndicatorsCh(CalendarRequest request)
    {
        var result = await _ptmProvider.LeadingIndicatorsCh(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> MarkitServicesPmiEU(CalendarRequest request)
    {
        var result = await _ptmProvider.MarkitServicesPmiEU(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> UnemploymentRateEU(CalendarRequest request)
    {
        var result = await _ptmProvider.UnemploymentRateEU(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> MarkitManufacturingPmiEU(CalendarRequest request)
    {
        var result = await _ptmProvider.MarkitManufacturingPmiEU(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> M3MoneySupplyEU(CalendarRequest request)
    {
        var result = await _ptmProvider.M3MoneySupplyEU(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> ConsumerConfidenceEU(CalendarRequest request)
    {
        var result = await _ptmProvider.ConsumerConfidenceEU(request);
        return Ok(result);
    }

    [HttpPost]
    public List<string> IsmPmiHelper(string request)
    {
        var number = 18;
        var result = request.Split(';').ToList();
        for (var i = 0; i < result.Count; i++)
        {
            result[i] = result[i].TrimStart();
            result[i] += $" {number}";
            number -= 1;
        }

        result.Sort();
        return result;
    }
}
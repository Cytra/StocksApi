using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.FMP.CompanyOutlook;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class StockOverview
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }
        [Inject]
        public IStockPriceService StockPriceService { get; set; }

        public CompanyOutlookModel CompanyOutlook { get; set; }
        public StockPriceHistoric Prices { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Prices = await StockPriceService.GetHistoricPrices(StockTicker);
            CompanyOutlook = await IuiStockService.GetCompanyOutlook(StockTicker);
        }
    }
}

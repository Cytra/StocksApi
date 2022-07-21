using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class Dcf
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService StockService { get; set; }

        public Historical_discounted_cash_flows_Model DcfList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var dcfList = await StockService.GetDCF(StockTicker);
            if (dcfList.Count > 0)
            {
                foreach (var item in dcfList.First().historicalDCF)
                {
                    if (item.StockPrice > 1)
                    {
                        item.Ratio = item.DCF / item.StockPrice;
                    }
                }
                DcfList = dcfList.First();
            }
        }
    }
}

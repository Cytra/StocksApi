using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class EarningSurprice
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService StockService { get; set; }

        public List<Model.FMP.EarningSurprice.EarningSurprice> EarningSurpriceList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var earningSurpriceList = await StockService.EarningsSurprises(StockTicker);
            if (earningSurpriceList.Count > 0)
            {
                foreach (var item in earningSurpriceList)
                {
                    if (item.estimatedEarning != 0)
                    {
                        if (item.actualEarningResult > 0)
                        {
                            item.Dif = ((item.actualEarningResult / item.estimatedEarning) - 1);
                        }
                        else
                        {
                            item.Dif = ((item.actualEarningResult / item.estimatedEarning) - 1)* -1;
                        }
                        
                    }
                }
                EarningSurpriceList = earningSurpriceList;
            }
        }
    }
}

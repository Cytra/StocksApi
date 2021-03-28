using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class KeyMetrics
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }

        public List<Model.KeyMetrics.KeyMetrics> KeyMetricsList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var keyMetricsList = await IuiStockService.GetKeyMetrics(StockTicker);
            KeyMetricsList = keyMetricsList.OrderBy(x => x.date).ToList();
        }
    }
}

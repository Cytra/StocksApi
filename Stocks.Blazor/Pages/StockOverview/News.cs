using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.CompanyOutlook;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class News
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }

        public List<Stocknew> StocknewsList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var keyMetricsList = await IuiStockService.StockNews(StockTicker);
            StocknewsList = keyMetricsList;
        }
    }
}

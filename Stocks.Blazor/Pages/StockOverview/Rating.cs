using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.FMP.Rating;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class Rating
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }

        public List<RatingHistoric> RatingHistorics { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RatingHistorics = await IuiStockService.Rating(StockTicker);
        }
    }
}

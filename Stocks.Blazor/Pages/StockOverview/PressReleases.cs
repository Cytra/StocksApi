using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages.StockOverview
{
    public partial class PressReleases
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }

        public List<Model.PressReleases.PressReleases> PressReleasesList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PressReleasesList = await IuiStockService.GetPressReleases(StockTicker);
        }
    }
}

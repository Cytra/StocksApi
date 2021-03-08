using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Profile;
using Stocks.Model.Shared;
using Stocks.UI.Services;

namespace Stocks.UI.Pages
{
    public partial class StockOverview
    {
        [Parameter]
        public string StockTicker { get; set; }
        [Inject]
        public IUIStockService IuiStockService { get; set; }

        public StockProfile StockProfile { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var profiles = await IuiStockService.GetStockProfile(StockTicker);
            if (profiles.FirstOrDefault() != null)
            {
                StockProfile = profiles.First();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.FMP.GainersLosers;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class Home
    {
        [Inject]
        public IStockService IuiStockService { get; set; }
        public List<GainersLosers> GainersList { get; set; }
        public List<GainersLosers> LosersList { get; set; }
        protected override async Task OnInitializedAsync()
        {
            GainersList = await IuiStockService.Gainers();
            LosersList = await IuiStockService.Losers();
        }
    }
}

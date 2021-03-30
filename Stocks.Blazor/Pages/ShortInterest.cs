using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Core.Extensions;
using Stocks.Model.Reddit;
using Stocks.Model.Shared;
using Stocks.Model.StockPrice;

namespace Stocks.Blazor.Pages
{
    public partial class ShortInterest
    {
        [Inject] 
        public IShortInterestProvider ShortInterestProvider { get; set; }
        [Inject]
        public IStockPriceProvider StockPriceProvider { get; set; }
        [Inject]
        public IStockService IuiStockService { get; set; }
        public List<Model.ShortInterest.ShortInterest> ShortInterests { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var shortInterests = await ShortInterestProvider.GetShortInterestList();
            if (shortInterests != null)
            {
                var tickers = shortInterests.Select(x => x.Ticker).ToList();
                var prices = await StockPriceProvider.GetPricesForUi(new StockPricesForUiRequest()
                {
                    Tickers = tickers
                });
                foreach (var item in shortInterests)
                {
                    item.Prices = prices.FirstOrDefault(x => x.Ticker == item.Ticker);
                }

                var profiles = new List<Model.Profile.StockProfile>();
                var tickerLists = ListExtensions.Split(tickers, 5);
                foreach (var tickerList in tickerLists)
                {
                    var inputString = StringExtensions.GetSymbolsString(tickerList);
                    var profile = await IuiStockService.GetStockProfile(inputString);
                    profiles.AddRange(profile);
                }

                foreach (var item in shortInterests)
                {
                    var profileDoAdd = profiles.FirstOrDefault(x => x.Symbol == item.Ticker);
                    item.MarketCap = profileDoAdd?.MktCap;
                }
                ShortInterests = shortInterests.OrderByDescending(x=> x.Prices.Day.Performance).ToList();
            }
            else
            {
                ShortInterests = new List<Model.ShortInterest.ShortInterest>();
            }
        }
    }
}

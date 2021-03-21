using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Blazor.Services;
using Stocks.Model.Shared;
using Stocks.Model.YahooFinance;

namespace Stocks.Blazor.Pages
{
    public partial class OpenInterest
    {
        [Inject]
        public IYahooFinanceOtherProvider YahooFinanceOtherProvider { get; set; }
        public List<YahooFinanceOptionEntityGroupBy> YahooFinanceOptionEntityGroupByLists { get; set; }

        public List<List<YahooFinanceOptionEntityGroupBy>> AllStocks { get; set; }
        public string Ticker { get; set; }
        public List<string> StockList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            StockList = await YahooFinanceOtherProvider.GetOpenInterestStockList();
            var allList = new List<List<YahooFinanceOptionEntityGroupBy>>();
            foreach (var stock in StockList)
            {
                var stockList = await YahooFinanceOtherProvider.GetOpenInterest(stock);
                allList.Add(stockList);
            }
            AllStocks = allList;
        }
        private async void GetList()
        {
            if (!string.IsNullOrWhiteSpace(Ticker))
            {
                YahooFinanceOptionEntityGroupByLists = await YahooFinanceOtherProvider.GetOpenInterest(Ticker);
            }
            else
            {
                YahooFinanceOptionEntityGroupByLists = null;
            }
            StateHasChanged();
        }
    }
}

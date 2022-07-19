using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Stocks.Core.Services.ShortInterest;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;
using Stocks.Model.ShortInterest;

namespace Stocks.Core.Providers.Other
{
    public class ShortInterestProvider : IShortInterestProvider
    {
        private readonly IShortInterestService _shortInterestService;
        private readonly IStockPriceProvider _stockPriceProvider;
        public ShortInterestProvider(IShortInterestService shortInterestService, IStockPriceProvider stockPriceProvider)
        {
            _shortInterestService = shortInterestService;
            _stockPriceProvider = stockPriceProvider;
        }

        public async Task<List<ShortInterest>> GetShortInterestList()
        {
            var result = new List<ShortInterest>();
            var htmlString = await _shortInterestService.GetHighShortInterestData();
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlString);
            var callTable = htmlDoc.DocumentNode.Descendants("table").SingleOrDefault(node => node.GetAttributeValue("class", "").Contains("stocks"));
            if (callTable == null)
            {
                return null;
            }

            var callTrItems = callTable.ChildNodes.Where(x => x.Name == "tr").ToList();
            foreach (var node in callTrItems.Skip(1))
            {
                var items = node.ChildNodes.Where(x => x.Name == "td").ToList();
                if (items.Count >= 7)
                {
                    var canParseShortInterest = decimal.TryParse(items[3].InnerText[..^1], out decimal outputShortInterest);
                    var itemToAdd = new ShortInterest()
                    {
                        Ticker = items[0].InnerText,
                        Company = items[1].InnerText,
                        Exchange = items[2].InnerText,
                        ShortInt = canParseShortInterest ? outputShortInterest / 100: 0,
                        Float = items[4].InnerText,
                        OutStd = items[5].InnerText,
                        Industry = items[6].InnerText
                    };
                    result.Add(itemToAdd);
                }
            }

            var prices = await _stockPriceProvider.GetPricesForUi(
                new StockPricesForUiRequest(){ Tickers = result.Select(x => x.Ticker).ToList()});

            foreach (var item in result)
            {
                item.Prices = prices.FirstOrDefault(x => x.Ticker == item.Ticker);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Stocks.Core.Extensions;
using Stocks.Core.Helpers;
using Stocks.Core.Services.StockList;
using Stocks.Core.Services.StockPrice;
using Stocks.Model;
using Stocks.Model.FMP.StockPrice;
using Stocks.Model.Shared;

namespace Stocks.Core.Providers.Other
{

    public class StockPriceProvider : IStockPriceProvider
    {
        private readonly IStockPriceService _stockPriceService;
        private readonly IStockListService _stockListService;
        
        public StockPriceProvider(IStockPriceService stockPriceService, IStockListService stockListService)
        {
            _stockPriceService = stockPriceService;
            _stockListService = stockListService;
        }

        public async Task<List<StockPriceItem>> GetStockPrices(List<string> symbols)
        {
            var result = new List<StockPriceItem>();
            var stockSplits = ListExtensions.Split(symbols, 10);
            foreach (var stockSplit in stockSplits)
            {
                var stockSymbols = StringExtensions.GetSymbolsString(stockSplit);
                var prices = await _stockPriceService.GetStockPrices(stockSymbols);
                foreach (var price in prices)
                {
                    result.Add(price);
                }
            }
            return result;
        }

        public async Task<List<StockPricesForUi>> GetPricesForUi(StockPricesForUiRequest request)
        {
            var ticker = request.Tickers;
            var result = new List<StockPricesForUi>();
            var resultPrices = new List<StockPriceHistoric>();

            if (ticker.Count != 0)
            {
                var stockSplits = ListExtensions.Split(ticker, 5);
                foreach (var stockSplit in stockSplits)
                {
                    var stockSymbols = StringExtensions.GetSymbolsString(stockSplit);
                    var currentPrices = await _stockPriceService.GetStockPrices(stockSymbols);
                    var prices = await _stockPriceService.GetHistoricPrices(stockSymbols, DateTime.Now.AddDays(-100), DateTime.Now);
                    if (prices.HistoricalStockList != null && currentPrices != null)
                    {
                        foreach (var price in prices.HistoricalStockList)
                        {
                            var currentStockPrice = currentPrices.First(x => x.Symbol == price.Symbol).Price;
                            price.Historical.Add(new StockPriceHistoricItem()
                            {
                                AdjClose = currentStockPrice,
                                Date = DateTime.Now.Date,
                                Change = price.Historical[0].AdjClose - currentStockPrice,
                                ChangePercent = (currentStockPrice - price.Historical[0].AdjClose) / price.Historical[0].AdjClose
                            });
                            price.Historical = price.Historical.OrderByDescending(x => x.Date).ToList();
                            resultPrices.Add(price);
                        }
                    }

                }
            }

            foreach (var prices in resultPrices)
            {
                var dto = new StockPricesForUi()
                {
                    Ticker = prices.Symbol
                };
                if (prices.Historical != null && prices.Historical.Count >= 61)
                {
                    if (prices.Historical[0] != null)
                    {

                        if (prices.Historical[1] != null)
                        {
                            dto.Day = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[1].AdjClose) / prices.Historical[1].AdjClose), 4, MidpointRounding.AwayFromZero)

                            };
                        }
                        if (prices.Historical[2] != null)
                        {
                            dto.TwoDay = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[2].AdjClose) / prices.Historical[2].AdjClose), 4, MidpointRounding.AwayFromZero)

                            };
                        }
                        if (prices.Historical[3] != null)
                        {
                            dto.ThreeDay = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[3].AdjClose) / prices.Historical[3].AdjClose), 4, MidpointRounding.AwayFromZero)

                            };
                        }
                        if (prices.Historical[5] != null)
                        {
                            dto.Week = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[5].AdjClose) / prices.Historical[5].AdjClose), 4, MidpointRounding.AwayFromZero)
                            };
                        }
                        if (prices.Historical[20] != null)
                        {
                            dto.Month = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[20].AdjClose) / prices.Historical[20].AdjClose), 4, MidpointRounding.AwayFromZero)
                            };
                        }
                        if (prices.Historical[60] != null)
                        {
                            dto.ThreeMonths = new StockPriceForUi()
                            {
                                Performance = decimal.Round(((prices.Historical[0].AdjClose - prices.Historical[60].AdjClose) / prices.Historical[60].AdjClose), 4, MidpointRounding.AwayFromZero)
                            };
                        }
                    }
                }
                result.Add(dto);
            }

            return result;
        }
    }
}

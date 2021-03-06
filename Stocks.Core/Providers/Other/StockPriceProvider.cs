﻿using System;
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
using Stocks.Model.Reddit;
using Stocks.Model.Shared;
using Stocks.Model.StockPrice;

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

        public async Task<RedditDdDtoList> GetStockPricesForUi(List<RedditDdDto> dtos, RedditOtherRequest request)
        {
            string pattern = @"[A-Z]{2,}";
            var regex = new Regex(pattern);
            var tickers = new List<string>();
            var validatedTickers = new List<string>();
            var stockList = await _stockListService.GetStockList();
            foreach (var dto in dtos)  
            {
                if (!string.IsNullOrWhiteSpace(dto.title))
                {
                    var potentialTickers = dto.title.Split();
                    var uppercaseTickers = new List<string>();
                    foreach (var val in potentialTickers)
                    {
                        var match = regex.Match(val);
                        if (!string.IsNullOrWhiteSpace(match.Value) && !StockLists.TickerBlackList.Contains(match.Value))
                        {
                            if (!tickers.Contains(match.Value))
                            {
                                tickers.Add(match.Value);
                            }
                            uppercaseTickers.Add(match.Value);
                        }
                    }

                    dto.PotentialTickers = uppercaseTickers;
                }
            }

            foreach (var ticker in tickers)
            {
                if (stockList.Select(x => x.Symbol).Contains(ticker))
                {
                    validatedTickers.Add(ticker);
                }
            }

            var result = new List<StockPriceHistoric>();

            if (validatedTickers.Count != 0)
            {
                var stockSplits = ListExtensions.Split(validatedTickers, 5);
                foreach (var stockSplit in stockSplits)
                {
                    var stockSymbols = StringExtensions.GetSymbolsString(stockSplit);
                    var prices = await _stockPriceService.GetHistoricPrices(stockSymbols, DateTime.Now.AddDays(-100), DateTime.Now);
                    if (prices.HistoricalStockList != null)
                    {
                        foreach (var price in prices.HistoricalStockList)
                        {
                            result.Add(price);
                        }
                    }

                }
            }

            foreach (var dto in dtos)
            {
                dto.Prices = new StockPricesForUi();
                foreach (var potentialTicker in dto.PotentialTickers)
                {
                    var prices = result.Where(x => x.Symbol.Contains(potentialTicker)).ToList();
                    if (prices.Count != 0 && prices[0].Historical != null && prices[0].Historical.Count >= 61)
                    {
                        dto.Ticker = prices[0].Symbol;
                        if (prices[0].Historical[0] != null)
                        {
                            
                            if (prices[0]?.Historical[1] != null)
                            {
                                dto.Prices.Day = new StockPriceForUi()
                                {
                                    Performance =
                                        decimal.Round(((prices[0].Historical[0].AdjClose - prices[0].Historical[1].AdjClose) / prices[0].Historical[1].AdjClose), 2, MidpointRounding.AwayFromZero)
                                
                                        //.ToString("P2", new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 })
                                };
                            }
                            if (prices[0]?.Historical[5] != null)
                            {
                                dto.Prices.Week = new StockPriceForUi()
                                {
                                    Performance =
                                        decimal.Round(((prices[0].Historical[0].AdjClose - prices[0].Historical[5].AdjClose) / prices[0].Historical[5].AdjClose), 2, MidpointRounding.AwayFromZero)
                                        
                                        
                                    //.ToString("P2", new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 })
                                };
                            }
                            if (prices[0]?.Historical[20] != null)
                            {
                                dto.Prices.Month = new StockPriceForUi()
                                {
                                    Performance =
                                        decimal.Round(((prices[0].Historical[0].AdjClose - prices[0].Historical[20].AdjClose) / prices[0].Historical[20].AdjClose), 2, MidpointRounding.AwayFromZero)
                                
                                        //.ToString("P2", new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 })
                                };
                            }
                            if (prices[0]?.Historical[60] != null)
                            {
                                dto.Prices.ThreeMonths = new StockPriceForUi()
                                {
                                    Performance = decimal.Round(((prices[0].Historical[0].AdjClose - prices[0].Historical[60].AdjClose) / prices[0].Historical[60].AdjClose), 2, MidpointRounding.AwayFromZero)
                                
                                        //.ToString("P2", new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 })
                                };
                            }
                        }
                    }
                }
            }

            return new RedditDdDtoList()
            {
                Aggregated = GetAggregateds(dtos),
                Items = dtos,
                Paging = new PagingModel()
                {
                    Page = request.Page,
                    PageSize = request.RowsPerPage,
                    TotalItems = result.Count
                }
            };
        }

        private List<RedditDdDtoAggregated> GetAggregateds(List<RedditDdDto> dtos)
        {
            var result = new List<RedditDdDtoAggregated>();
            var tickers = dtos.Where(x => !string.IsNullOrWhiteSpace(x.Ticker))
                .Select(x => x.Ticker).Distinct()
                .ToList();
            foreach (var ticker in tickers)
            {
                var aggregatedToAdd = new RedditDdDtoAggregated()
                {
                    OneWeekPosts = dtos.Where(x=> x.Ticker == ticker).Count(x => x.created_utc >= DateTimeOffset.Now.AddDays(-5).ToUnixTimeSeconds() && x.created_utc <= DateTimeOffset.Now.ToUnixTimeSeconds()),
                    TwoWeekPosts = dtos.Where(x => x.Ticker == ticker).Count(x => x.created_utc >= DateTimeOffset.Now.AddDays(-10).ToUnixTimeSeconds() && x.created_utc <= DateTimeOffset.Now.AddDays(-5).ToUnixTimeSeconds()),
                    ThreeWeekPosts = dtos.Where(x => x.Ticker == ticker).Count(x => x.created_utc >= DateTimeOffset.Now.AddDays(-15).ToUnixTimeSeconds() && x.created_utc <= DateTimeOffset.Now.AddDays(-10).ToUnixTimeSeconds()),
                    FourWeekPosts = dtos.Where(x => x.Ticker == ticker).Count(x => x.created_utc >= DateTimeOffset.Now.AddDays(-20).ToUnixTimeSeconds() && x.created_utc <= DateTimeOffset.Now.AddDays(-15).ToUnixTimeSeconds()),
                    Prices = dtos.First(x=> x.Ticker == ticker).Prices,
                    Ticker = ticker,
                };
                result.Add(aggregatedToAdd);
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

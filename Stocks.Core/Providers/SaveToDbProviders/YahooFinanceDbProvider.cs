using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Stocks.Core.Services;
using Stocks.Data.Entities.YahooFinance;
using Stocks.Data.Repositories;
using Stocks.Model.YahooFinance;

namespace Stocks.Core.Providers.SaveToDbProviders
{
    public interface IYahooFinanceDbProvider
    {
        Task GetStockOptionOpenInterest(string ticker);
    }
    public class YahooFinanceDbProvider : IYahooFinanceDbProvider
    {
        private readonly IYahooFinanceService _yahooFinanceService;
        private readonly IStocksRepository _stocksRepository;
        public YahooFinanceDbProvider(IYahooFinanceService yahooFinanceService, IStocksRepository stocksRepository)
        {
            _yahooFinanceService = yahooFinanceService;
            _stocksRepository = stocksRepository;
        }
        public async Task GetStockOptionOpenInterest(string ticker)
        {
            var allEntities = new List<YahooFinanceOptionEntity>();
            var dates = await GetDates(ticker);
            foreach (var date in dates)
            {
                var entitiesToAdd = await GetOptionData(ticker, date);
                allEntities.AddRange(entitiesToAdd);
            }

            await _stocksRepository.SaveYahooFinanceOptionEntities(allEntities);
        }

        private async Task<List<YahooFinanceOptionEntity>> GetOptionData(string ticker, string date)
        {
            var entities = new List<YahooFinanceOptionEntity>();
            var htmlString = await _yahooFinanceService.GetStockOptionData(ticker, date);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlString);
            var callTable = htmlDoc.DocumentNode.Descendants("table").Single(node => node.GetAttributeValue("class", "").Contains("W(100%) Pos(r) Bd(0) Pt(0) list-options"));
            var callBody = callTable.ChildNodes.Single(x => x.Name == "tbody");
            var callTrItems = callBody.ChildNodes.Where(x => x.Name == "tr").ToList();
            foreach (var node in callTrItems)
            {
                var optionName = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col0 Ta(start) Pstart(10px) Bdstartw(8px) Bdstarts(s) Bdstartc(t) in-the-money_Bdstartc($linkColor)")).InnerText;

                var strikePrice = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col2 Ta(end) Px(10px)")).InnerText;
                var strikePriceCanparse = decimal.TryParse(strikePrice, out decimal strikePriceValue);

                var openInterest = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col8 Ta(end) Pstart(7px)")).InnerText;
                var openInterestCanparse = int.TryParse(openInterest, out int openInterestValue);

                var entityToInsert = new YahooFinanceOptionEntity()
                {
                    Created = DateTimeOffset.Now,
                    Ticker = ticker,
                    Type = OptionType.Call,
                    OptionName = optionName,
                    OpenInterest = openInterestCanparse ? openInterestValue : 0,
                    StrikePrice = strikePriceCanparse ? strikePriceValue : 0
                };
                entities.Add(entityToInsert);
            }

            var putTable = htmlDoc.DocumentNode.Descendants("table").Single(node => node.GetAttributeValue("class", "").Contains("puts W(100%) Pos(r) list-options"));
            var putBody = putTable.ChildNodes.Single(x => x.Name == "tbody");
            var putTrItems = putBody.ChildNodes.Where(x => x.Name == "tr").ToList();
            foreach (var node in putTrItems)
            {
                var optionName = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col0 Ta(start) Pstart(10px) Bdstartw(8px) Bdstarts(s) Bdstartc(t) in-the-money_Bdstartc($linkColor)")).InnerText;

                var strikePrice = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col2 Ta(end) Px(10px)")).InnerText;
                var strikePriceCanparse = decimal.TryParse(strikePrice, out decimal strikePriceValue);

                var openInterest = node.ChildNodes.Single(x =>
                    x.Attributes.Any(y => y.Value == "data-col8 Ta(end) Pstart(7px)")).InnerText;
                var openInterestCanparse = int.TryParse(openInterest, out int openInterestValue);

                var entityToInsert = new YahooFinanceOptionEntity()
                {
                    Created = DateTimeOffset.Now,
                    Ticker = ticker,
                    Type = OptionType.Put,
                    OptionName = optionName,
                    OpenInterest = openInterestCanparse ? openInterestValue : 0,
                    StrikePrice = strikePriceCanparse ? strikePriceValue : 0
                };
                entities.Add(entityToInsert);
            }

            return entities;
        }

        private async Task<List<string>> GetDates(string ticker)
        {
            var result = new List<string>();
            var htmlString = await _yahooFinanceService.GetStockOptionData(ticker, null);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlString);
            var datesDiv = htmlDoc.DocumentNode
                .Descendants("div").Single(node => node.GetAttributeValue("class", "").Contains("Fl(start) Pend(18px)"));
            var child = datesDiv.FirstChild;
            var listItems = child.ChildNodes;
            foreach (var item in listItems)
            {
                var date = item.Attributes.Single(x => x.Name == "value").Value;
                result.Add(date);
            }
            return result;
        }
    }
}

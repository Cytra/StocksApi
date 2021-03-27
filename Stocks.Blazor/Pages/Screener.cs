using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Stocks.Model.Screener;
using Stocks.Model.Shared;

namespace Stocks.Blazor.Pages
{
    public partial class Screener
    {
        [Inject] public IStockScreenerPrivider StockScreenerPrivider { get; set; }
        public StockScreenerResponseList Response { get; set; }
        public List<StockScreenerResponse> Stocks { get; set; }
        public List<string> MarketCapList { get; set; } = new List<string>()
        {
            "Any",
            "Mega ($200bln and more)",
            "Large ($10bln to $200bln)",
            "Mid ($2bln to $10bln)",
            "Small ($300mln to $2bln)",
            "Micro ($50mln $300mln)",
            "Nano (under $50mln)",
            "+Large (over $10bln)",
            "+Mid (over $2bln)",
            "+Small (over $300mln)",
            "+Micro (over $50mln)",
            "-Large (under $200bln)",
            "-Mid (under $10bln)",
            "-Small (under $2bln)",
            "-Micro (under $300 mln)"
        };
        public List<string> BetaList { get; set; } = new List<string>()
        {
            "Any",
            "Under 0",
            "Under 0.5",
            "Under 1",
            "Under 1.5",
            "Under 2",
            "Over 0",
            "Over 0.5",
            "Over 1",
            "Over 1.5",
            "Over 2",
            "Over 2.5",
            "Over 3",
            "Over 4",
            "0 to 0.5",
            "0 to 1",
            "0.5 to 1.5",
            "1 to 2"
        };
        public List<string> PriceList { get; set; } = new List<string>()
        {
            "Any",
            "Under 1$",
            "Under 2$",
            "Under 3$",
            "Under 4$",
            "Under 5$",
            "Under 7$",
            "Under 10$",
            "Under 15$",
            "Under 20$",
            "Under 30$",
            "Under 40$",
            "Under 50$",
            "Over $1",
            "Over $2",
            "Over $3",
            "Over $4",
            "Over $5",
            "Over $7",
            "Over $10",
            "Over $15",
            "Over $20",
            "Over $30",
            "Over $40",
            "Over $50",
            "Over $60",
            "Over $70",
            "Over $80",
            "Over $90",
            "Over $100",
            "$1 to $5",
            "$1 to $10",
            "$1 to $20",
            "$5 to $10",
            "$5 to $20",
            "$5 to $50",
            "$10 to $20",
            "$10 to $50",
            "$20 to $50",
            "$50 to $100",

        };
        public List<string> VolumeList { get; set; } = new List<string>()
        {
            "Any",
            "Under 50K",
            "Under 100K",
            "Under 500K",
            "Under 750K",
            "Under 1M",
            "Over 50K",
            "Over 100K",
            "Over 200K",
            "Over 300K",
            "Over 400K",
            "Over 500K",
            "Over 750K",
            "Over 1M",
            "Over 2M",
            "100K to 500K",
            "100K to 1M",
            "500K to 1M",
            "500K to 10M"
        };
        public List<string> DividendYieldList { get; set; } = new List<string>()
        {
            "Any",
            "None (0%)",
            "Positive (>0%)",
            "High (>5%)",
            "Very High (>10%)",
            "Over 1%",
            "Over 2%",
            "Over 3%",
            "Over 4%",
            "Over 5%",
            "Over 6%",
            "Over 7%",
            "Over 8%",
            "Over 9%",
            "Over 10%",
        };
        public string SelectedMarketCap { get; set; }
        public string SelectedBeta { get; set; }
        public string SelectedPrice { get; set; }
        public string SelectedVolume { get; set; }
        public string SelectedDividendYield { get; set; }
        public string SelectedExchange { get; set; }
        public string SelectedCountry { get; set; }
        public string SelectedIndustry { get; set; }
        public string SelectedSector { get; set; }

        private async void GetStocks()
        {
            var request = new StockScreenerRequest();
            request.RowsPerPage = 50;
            AddMarketCapScreener(request);
            AddBetaScreener(request);
            AddPriceScreener(request);
            AddVolumeScreener(request);
            AddDividendYieldScreener(request);
            AddExchangeScreener(request);
            AddCountryScreener(request);
            AddIndustryScreener(request);
            AddSectorScreener(request);
            Response = await StockScreenerPrivider.GetStocks(request);
            GetItems(1);
        }

        private void AddSectorScreener(StockScreenerRequest request)
        {
            if (!string.IsNullOrWhiteSpace(SelectedSector) && SelectedSector != "Any")
            {
                request.Sector = (Sector)Enum.Parse(typeof(Sector), SelectedSector, true);
            }
            else
            {
                request.Sector = null;
            }
        }
        private void AddIndustryScreener(StockScreenerRequest request)
        {
            if (!string.IsNullOrWhiteSpace(SelectedIndustry) && SelectedIndustry != "Any")
            {
                request.Industry = (Industry)Enum.Parse(typeof(Industry), SelectedIndustry, true);
            }
            else
            {
                request.Industry = null;
            }
        }
        private void AddCountryScreener(StockScreenerRequest request)
        {
            if (!string.IsNullOrWhiteSpace(SelectedCountry) && SelectedCountry != "Any")
            {
                request.Country = (Country)Enum.Parse(typeof(Country), SelectedCountry, true);
            }
            else
            {
                request.Country = null;
            }
        }
        private void AddExchangeScreener(StockScreenerRequest request)
        {
            if (!string.IsNullOrWhiteSpace(SelectedExchange) && SelectedExchange != "Any")
            {
                request.Exchange = (Exchange)Enum.Parse(typeof(Exchange),SelectedExchange,true);
            }
            else
            {
                request.Exchange = null;
            }
        }
        private void AddDividendYieldScreener(StockScreenerRequest request)
        {
            switch (SelectedDividendYield)
            {
                case "Any":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = null;
                    break;
                case "None (0%)":
                    request.DividendYieldLowerThan = 0;
                    request.DividendYieldMoreThan = 0;
                    break;
                case "Positive (>0%)":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0;
                    break;
                case "High (>5%)":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.05M;
                    break;
                case "Very High (>10%)":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.10M;
                    break;
                case "Over 1%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.01M;
                    break;
                case "Over 2%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.02M;
                    break;
                case "Over 3%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.03M;
                    break;
                case "Over 4%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.04M;
                    break;
                case "Over 5%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.05M;
                    break;
                case "Over 6%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.06M;
                    break;
                case "Over 7%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.07M;
                    break;
                case "Over 8%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.08M;
                    break;
                case "Over 9%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.09M;
                    break;
                case "Over 10%":
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = 0.10M;
                    break;
                default:
                    request.DividendYieldLowerThan = null;
                    request.DividendYieldMoreThan = null;
                    break;
            }
        }
        private void AddVolumeScreener(StockScreenerRequest request)
        {
            switch (SelectedVolume)
            {
                case "Any":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = null;
                    break;
                case "Under 50K":
                    request.VolumeLowerThan = 50000;
                    request.VolumeMoreThan = null;
                    break;
                case "Under 100K":
                    request.VolumeLowerThan = 100000;
                    request.VolumeMoreThan = null;
                    break;
                case "Under 500K":
                    request.VolumeLowerThan = 500000;
                    request.VolumeMoreThan = null;
                    break;
                case "Under 750K":
                    request.VolumeLowerThan = 750000;
                    request.VolumeMoreThan = null;
                    break;
                case "Under 1M":
                    request.VolumeLowerThan = 1000000;
                    request.VolumeMoreThan = null;
                    break;
                case "Over 50K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 50000;
                    break;
                case "Over 100K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 100000;
                    break;
                case "Over 200K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 200000;
                    break;
                case "Over 300K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 300000;
                    break;
                case "Over 400K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 400000;
                    break;
                case "Over 500K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 500000;
                    break;
                case "Over 750K":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 750000;
                    break;
                case "Over 1M":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 1000000;
                    break;
                case "Over 2M":
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = 2000000;
                    break;
                case "100K to 500K":
                    request.VolumeLowerThan = 500000;
                    request.VolumeMoreThan = 100000;
                    break;
                case "100K to 1M":
                    request.VolumeLowerThan = 1000000;
                    request.VolumeMoreThan = 100000;
                    break;
                case "500K to 1M":
                    request.VolumeLowerThan = 1000000;
                    request.VolumeMoreThan = 500000;
                    break;
                case "500K to 10M":
                    request.VolumeLowerThan = 10000000;
                    request.VolumeMoreThan = 500000;
                    break;
                default:
                    request.VolumeLowerThan = null;
                    request.VolumeMoreThan = null;
                    break;
            }
        }
        private void AddPriceScreener(StockScreenerRequest request)
        {
            switch (SelectedPrice)
            {
                case "Any":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = null;
                    break;
                case "Under 1$":
                    request.PriceLowerThan = 1;
                    request.PriceMoreThan = null;
                    break;
                case "Under 2$":
                    request.PriceLowerThan = 2;
                    request.PriceMoreThan = null;
                    break;
                case "Under 3$":
                    request.PriceLowerThan = 3;
                    request.PriceMoreThan = null;
                    break;
                case "Under 4$":
                    request.PriceLowerThan = 4;
                    request.PriceMoreThan = null;
                    break;
                case "Under 5$":
                    request.PriceLowerThan = 5;
                    request.PriceMoreThan = null;
                    break;
                case "Under 7$":
                    request.PriceLowerThan = 7;
                    request.PriceMoreThan = null;
                    break;
                case "Under 10$":
                    request.PriceLowerThan = 10;
                    request.PriceMoreThan = null;
                    break;
                case "Under 15$":
                    request.PriceLowerThan = 15;
                    request.PriceMoreThan = null;
                    break;
                case "Under 20$":
                    request.PriceLowerThan = 20;
                    request.PriceMoreThan = null;
                    break;
                case "Under 30$":
                    request.PriceLowerThan = 30;
                    request.PriceMoreThan = null;
                    break;
                case "Under 40$":
                    request.PriceLowerThan = 40;
                    request.PriceMoreThan = null;
                    break;
                case "Under 50$":
                    request.PriceLowerThan = 50;
                    request.PriceMoreThan = null;
                    break;
                case "Over $1":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 1;
                    break;
                case "Over $2":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 2;
                    break;
                case "Over $3":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 3;
                    break;
                case "Over $4":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 4;
                    break;
                case "Over $5":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 5;
                    break;
                case "Over $7":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 7;
                    break;
                case "Over $10":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 10;
                    break;
                case "Over $15":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 15;
                    break;
                case "Over $20":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 20;
                    break;
                case "Over $30":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 30;
                    break;
                case "Over $40":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 40;
                    break;
                case "Over $50":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 50;
                    break;
                case "Over $60":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 60;
                    break;
                case "Over $70":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 70;
                    break;
                case "Over $80":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 80;
                    break;
                case "Over $90":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 90;
                    break;
                case "Over $100":
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = 100;
                    break;
                case "$1 to $5":
                    request.PriceLowerThan = 5;
                    request.PriceMoreThan = 1;
                    break;
                case "$1 to $10":
                    request.PriceLowerThan = 10;
                    request.PriceMoreThan = 1;
                    break;
                case "$1 to $20":
                    request.PriceLowerThan = 20;
                    request.PriceMoreThan = 1;
                    break;
                case "$5 to $10":
                    request.PriceLowerThan = 10;
                    request.PriceMoreThan = 5;
                    break;
                case "$5 to $20":
                    request.PriceLowerThan = 20;
                    request.PriceMoreThan = 5;
                    break;
                case "$5 to $50":
                    request.PriceLowerThan = 50;
                    request.PriceMoreThan = 5;
                    break;
                case "$10 to $20":
                    request.PriceLowerThan = 20;
                    request.PriceMoreThan = 10;
                    break;
                case "$10 to $50":
                    request.PriceLowerThan = 50;
                    request.PriceMoreThan = 10;
                    break;
                case "$20 to $50":
                    request.PriceLowerThan = 50;
                    request.PriceMoreThan = 20;
                    break;
                case "$50 to $100":
                    request.PriceLowerThan = 100;
                    request.PriceMoreThan = 50;
                    break;
                default:
                    request.PriceLowerThan = null;
                    request.PriceMoreThan = null;
                    break;
            }
        }
        private void AddBetaScreener(StockScreenerRequest request)
        {
            switch (SelectedBeta)
            {
                case "Any":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = null;
                    break;
                case "Under 0":
                    request.BetaLowerThan = 0;
                    request.BetaMoreThan = null;
                    break;
                case "Under 0.5":
                    request.BetaLowerThan = 0.5M;
                    request.BetaMoreThan = null;
                    break;
                case "Under 1":
                    request.BetaLowerThan = 1;
                    request.BetaMoreThan = null;
                    break;
                case "Under 1.5":
                    request.BetaLowerThan = 1.5M;
                    request.BetaMoreThan = null;
                    break;
                case "Under 2":
                    request.BetaLowerThan = 2;
                    request.BetaMoreThan = null;
                    break;
                case "Over 0":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 0;
                    break;
                case "Over 0.5":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 0.5M;
                    break;
                case "Over 1":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 1;
                    break;
                case "Over 1.5":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 1.5M;
                    break;
                case "Over 2":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 2;
                    break;
                case "Over 2.5":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 2.5M;
                    break;
                case "Over 3":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 3;
                    break;
                case "Over 4":
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = 4;
                    break;
                case "0 to 0.5":
                    request.BetaLowerThan = 0.5M;
                    request.BetaMoreThan = 0;
                    break;
                case "0 to 1":
                    request.BetaLowerThan = 1;
                    request.BetaMoreThan = 0;
                    break;
                case "0.5 to 1.5":
                    request.BetaLowerThan = 1.5M;
                    request.BetaMoreThan = 0.5M;
                    break;
                case "1 to 2":
                    request.BetaLowerThan = 2;
                    request.BetaMoreThan = 1;
                    break;
                default:
                    request.BetaLowerThan = null;
                    request.BetaMoreThan = null;
                    break;
            }
        }
        private void AddMarketCapScreener(StockScreenerRequest request)
        {
            switch (SelectedMarketCap)
            {
                case "Any":
                    request.MarketCapLowerThan = null;
                    request.MarketCapMoreThan = null;
                    break;
                case "Mega ($200bln and more)":
                    request.MarketCapMoreThan = 200000000000;
                    request.MarketCapLowerThan = null;
                    break;
                case "Large ($10bln to $200bln)":
                    request.MarketCapLowerThan = 200000000000;
                    request.MarketCapMoreThan   = 10000000000;
                    break;
                case "Mid ($2bln to $10bln)":
                    request.MarketCapLowerThan = 10000000000;
                    request.MarketCapMoreThan   = 2000000000;
                    break;
                case "Small ($300mln to $2bln)":
                    request.MarketCapLowerThan = 2000000000;
                    request.MarketCapMoreThan   = 300000000;
                    break;
                case "Micro ($50mln $300mln)":
                    request.MarketCapLowerThan = 300000000;
                    request.MarketCapMoreThan = 50000000;
                    break;
                case "Nano (under $50mln)":
                    request.MarketCapLowerThan = 50000000;
                    request.MarketCapMoreThan = null;
                    break;
                case "+Large (over $10bln)":
                    request.MarketCapMoreThan = 10000000000;
                    request.MarketCapLowerThan = null;
                    break;
                case "+Mid (over $2bln)":
                    request.MarketCapMoreThan = 2000000000;
                    request.MarketCapLowerThan = null;
                    break;
                case "+Small (over $300mln)":
                    request.MarketCapMoreThan = 300000000;
                    request.MarketCapLowerThan = null;
                    break;
                case "+Micro (over $50mln)":
                    request.MarketCapMoreThan = 50000000;
                    request.MarketCapLowerThan = null;
                    break;
                case "-Large (under $200bln)":
                    request.MarketCapLowerThan = 200000000000;
                    request.MarketCapMoreThan = null;
                    break;
                case "-Mid (under $10bln)":
                    request.MarketCapLowerThan = 10000000000;
                    request.MarketCapMoreThan = null;
                    break;
                case "-Small (under $2bln)":
                    request.MarketCapLowerThan = 2000000000;
                    request.MarketCapMoreThan = null;
                    break;
                case "-Micro (under $300 mln)":
                    request.MarketCapLowerThan = 300000000;
                    request.MarketCapMoreThan = null;
                    break;
                default:
                    request.MarketCapLowerThan = null;
                    request.MarketCapMoreThan = null;
                    break;
            }
        }
        private void GetItems(int getPage)
        {
            Response.Paging.Page = getPage;
            var query = Response.Items;
            Stocks = query
                .Skip(Response.Paging.PageSize * (getPage - 1))
                .Take(Response.Paging.PageSize).ToList();
            StateHasChanged();
        }
    }
}

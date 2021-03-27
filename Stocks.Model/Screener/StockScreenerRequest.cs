using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Stocks.Model.Screener
{
    public class StockScreenerRequest
    {   
        //DONE
        public BigInteger? MarketCapMoreThan { get; set; }
        //DONE
        public BigInteger? MarketCapLowerThan { get; set; }
        //DONE
        public decimal? PriceMoreThan { get; set; }
        //DONE
        public decimal? PriceLowerThan { get; set; }
        //DONE
        public decimal? BetaMoreThan { get; set; }
        //DONE
        public decimal? BetaLowerThan { get; set; }
        //DONE
        public BigInteger? VolumeMoreThan { get; set; }
        //DONE
        public BigInteger? VolumeLowerThan { get; set; }
        public decimal? DividendMoreThan { get; set; }
        public decimal? DividendLowerThan { get; set; }
        //DONE
        public decimal? DividendYieldMoreThan { get; set; }
        //DONE
        public decimal? DividendYieldLowerThan { get; set; }
        public bool? IsEtf { get; set; }
        public bool? IsActivelyTrading { get; set; }
        public int? Limit { get; set; }
        //DONE
        public Exchange? Exchange { get; set; }
        //DONE
        public Country? Country { get; set; }
        //DONE
        public Industry? Industry { get; set; }
        public Sector? Sector { get; set; }
        public int RowsPerPage { get; set; }
    }

    public enum Sector
    {
        Cyclical,
        Energy,
        Technology,
        Industrials,
        [Description("Financial Services")]
        FinancialServices,
        [Description("Basic Materials")]
        BasicMaterials,
        [Description("Communication Services")]
        CommunicationServices,
        [Description("Consumer Defensive")]
        ConsumerDefensive,
        Healthcare,
        [Description("Real Estate")]
        RealEstate,
        Utilities,
        [Description("Industrial Goods")]
        IndustrialGoods,
        Financial,
        Services,
        Conglomerates
    }

    public enum Industry
    {
        Autos,
        Banks,
        [Description("Banks Diversified")]
        BanksDiversified,
        Software,
        [Description("Banks Regional")]
        BanksRegional,
        [Description("Beverages Alcoholic")]
        BeveragesAlcoholic,
        [Description("Beverages Brewers")]
        BeveragesBrewers,
        [Description("Beverages Non-Alcoholic")]
        BeveragesNonAlcoholic
    }

    public enum Exchange
    {
        nyse,
        nasdaq,
        amex,
        euronex,
        tsx,
        etf,
        mutual_fund
    }

    public enum Country
    {
        US,
        UK,
        MX,
        BR,
        RU,
        HK,
        CA
    }
}

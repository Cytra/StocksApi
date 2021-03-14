using System;
using AutoMapper;
using Stocks.Core.Helpers;
using Stocks.Data.Entities;
using Stocks.Data.Entities.DCF;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Entities.Index;
using Stocks.Data.Entities.Portfolio;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Entities.Reddit;
using Stocks.Data.Entities.StockPrice;
using Stocks.Model.DCF;
using Stocks.Model.Dividend;
using Stocks.Model.FinancialStatements;
using Stocks.Model.Index;
using Stocks.Model.Portfolio;
using Stocks.Model.Reddit;
using Stocks.Model.StockPrice;
using Link_Flair_Richtext = Stocks.Model.Reddit.Link_Flair_Richtext;

namespace Stocks.Core.Profiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Historical_discounted_cash_flow_Model, Historical_discounted_cash_flow_Entity>();

            CreateMap<DividendCalendarItem, DividendCalendarEntity>();
            CreateMap<DividendCalendarItem2, DividendCalendarEntity2>();

            CreateMap<StockPriceHistoricItem, StockPriceHistoricEntity>();

            CreateMap<SPYconstituentModel, SPYconstituentEntity>();

            CreateMap<IncomeStatement, IncomeStatementEntity>();

            CreateMap<Model.Profile.StockProfile, StockProfileEntity>();

            CreateMap<BalanceSheet, BalanceSheetEntity>();

            CreateMap<StockPriceItem, StockPriceEntity>();

            CreateMap<PortfolioRequest, PortfolioEntity>();

            CreateMap<PortfolioEntity, PortfolioItem>();

            CreateMap<ChildData, RedditDdEntity>()
                .ForMember(dest => dest.Created, opt=> opt.MapFrom(src => DateTimeOffset.Now))
                .ForMember(dest => dest.RedditId, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                ;

            CreateMap<ChildData, RedditDdDto>();

            CreateMap<RedditDdEntity, RedditDdDto>()
                .ForMember(dest => dest.CreatedString, opt => opt.MapFrom(src => DateHelper.GetDateStringFromUnix(src.created_utc)));

            CreateMap<Link_Flair_Richtext, Data.Entities.Reddit.Link_Flair_Richtext>();
        }
    }
}

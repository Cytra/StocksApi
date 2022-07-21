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
using Stocks.Data.Entities.StockPrice;
using Stocks.Model.Fmp.DCF;
using Stocks.Model.Fmp.Dividend;
using Stocks.Model.Fmp.FinancialStatements;
using Stocks.Model.Fmp.Index;
using Stocks.Model.Fmp.StockPrice;
using Stocks.Model.Portfolio;

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

            CreateMap<Model.Fmp.Profile.StockProfile, StockProfileEntity>();

            CreateMap<BalanceSheet, BalanceSheetEntity>();

            CreateMap<StockPriceItem, StockPriceEntity>();

            CreateMap<PortfolioRequest, PortfolioEntity>();

            CreateMap<PortfolioEntity, PortfolioItem>();
        }
    }
}

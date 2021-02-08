using AutoMapper;
using Stocks.Data.Entities.DCF;
using Stocks.Data.Entities.Dividend;
using Stocks.Data.Entities.FinancialStatements;
using Stocks.Data.Entities.Index;
using Stocks.Data.Entities.Profile;
using Stocks.Data.Entities.StockPrice;
using Stocks.Model.DCF;
using Stocks.Model.Dividend;
using Stocks.Model.FinancialStatements;
using Stocks.Model.Index;
using Stocks.Model.StockPrice;

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
            //StockPriceEntity

            //        CreateMap<PaymentEntity, Payload>()
            //.ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
            //.ForMember(dest => dest.Currency, opt => opt.MapFrom(src => "EUR"))
            //.ForMember(dest => dest.TransactionId, opt => opt.MapFrom(src => src.PaymentId))
            //.ForMember(dest => dest.PaymentPurpose, opt => opt.MapFrom(src => src.Purpose))
            //.ForMember(dest => dest.ReceiverAccountNumber, opt => opt.MapFrom(src => src.ReceiverIBAN))
            //.ForMember(dest => dest.Default_country, opt => opt.MapFrom(src => "LT"))
            //;
        }
    }
}

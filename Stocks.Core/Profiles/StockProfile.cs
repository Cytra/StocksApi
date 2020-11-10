using AutoMapper;
using Stocks.Data.Entities.DCF;
using Stocks.Model.FMP.Requests.DCF;

namespace Stocks.Core.Profiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Historical_discounted_cash_flow_Model, Historical_discounted_cash_flow_Entity>();


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

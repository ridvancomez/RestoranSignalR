using AutoMapper;
using SignalR.DTOLayer.MoneyCase;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Mapping
{
    public class MoneyCaseMapping : Profile
    {
        public MoneyCaseMapping()
        {
            CreateMap<MoneyCase, ResultMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, CreateMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, UpdateMoneyCaseDto>().ReverseMap();
            CreateMap<MoneyCase, GetMoneyCaseDto>().ReverseMap();
        }
    }
}

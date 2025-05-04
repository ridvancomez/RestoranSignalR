using AutoMapper;
using SignalR.DTOLayer.ContactUs;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Mapping
{
    public class ContactUsMapping : Profile
    {
        public ContactUsMapping()
        {
            CreateMap<ContactUs, ResultContactUsDto>().ReverseMap();
            CreateMap<ContactUs, CreateContactUsDto>().ReverseMap();
            CreateMap<ContactUs, UpdateContactUsDto>().ReverseMap();
            CreateMap<ContactUs, GetContactUsDto>().ReverseMap();
        }
    }
}

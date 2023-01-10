using AutoMapper;
using OrderManagement.Api.Dto;
using OrderManagement.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<City, CityDto>()
                .ForMember(dest => dest.StateDto, opt => opt.MapFrom(src => src.State))
                .ReverseMap();

            CreateMap<State, StateDto>()
              .ForMember(dest => dest.CityDto, opt => opt.MapFrom(src => src.City))
              .ReverseMap();

            CreateMap<Supplier, SupplierDto>()
               .ForMember(dest => dest.CityDto, opt => opt.MapFrom(src => src.City))
               .ForMember(dest => dest.StateDto, opt => opt.MapFrom(src => src.State))
               .ReverseMap();
        }
    }
}

using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<ResultOrderDto, Domain.Entities.Ordering>().ReverseMap();
            CreateMap<CreateOrderDto, Domain.Entities.Ordering>().ReverseMap();
            CreateMap<UpdateOrderDto, Domain.Entities.Ordering>().ReverseMap();
        }
    }
}

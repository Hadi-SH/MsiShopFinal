using AutoMapper;
using MsiShopFinal.Dtos;
using MsiShopFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MsiShopFinal.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Prods, ProdsDto>();
            Mapper.CreateMap<ProdsDto, Prods>();
        }
    }
}
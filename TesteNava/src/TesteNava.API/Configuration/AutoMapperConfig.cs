using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNava.API.ViewModels;
using TesteNava.Domain.Models;

namespace TesteNava.API.Configuration
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Sale, SaleViewModel>().ReverseMap();
            CreateMap<SaleItem, SaleItemViewModel>().ReverseMap();
            CreateMap<Seller, SellerViewModel>().ReverseMap();
        }
    }
}

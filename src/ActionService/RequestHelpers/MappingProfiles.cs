using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionService.DTOs;
using ActionService.Entities;
using AutoMapper;

namespace ActionService.RequestHelpers
{
    public class MappingProfiles : Profile
    {
       public MappingProfiles(){
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);

        CreateMap<Item, AuctionDto>();

        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
        }
    }
}
using AutoMapper;
using InstagramApp.DataEntity.Models;
using InstagramApp.DataTransferObject.Referral;
using InstagramApp.DataTransferObject.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            //mappings
            CreateMap<PostUser, User>()
                .ForMember(dto=>dto.Id,mem=>mem.MapFrom(src=>Guid.NewGuid().ToString("n")));
            CreateMap<PostReferral, Referral>()
                .ForMember(dto => dto.Id, mem => mem.Ignore());
        }
    }
}

using AutoMapper;
using MapperTest.Dto;
using MapperTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapperTest.Config
{
    public class MapperConfig: Profile
    {
        public MapperConfig() 
        {
            CreateMap<User,UserModel>();
            CreateMap<User,UserAppoint>().ForMember(dest=>dest.Time,opt=>opt.MapFrom(src=>src.CreateTime));
        }
    }
}

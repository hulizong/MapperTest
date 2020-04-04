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
            //简单转换
            CreateMap<User,UserModel>();
            CreateMap<User,UserInfoModel>();

            CreateMap<UserInfo,UserInfoModel>();
            
            //单个成员自定义配置
            CreateMap<User,UserAppoint>().ForMember(dest=>dest.Time,opt=>opt.MapFrom(src=>src.CreateTime));

            CreateMap<User,UserAppoint>().BeforeMap((old,newd)=> 
            {
                old.CreateTime = DateTime.Parse(old.CreateTime.ToString("yyyy-MM-dd"));
            }).AfterMap((old, newd) =>
            {
                newd.Time = old.CreateTime.ToString();
            });
        }
    }
}

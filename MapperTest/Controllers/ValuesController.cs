using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapperTest.Dto;
using MapperTest.Model;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MapperTest.Config;

namespace MapperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 简单对应字段转换
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(Get))]
        public ActionResult<string> Get()
        {
            var user = new User() 
            {
                Id=1,
                UserName= "TestUserName",
                PassWord= "TestPassWord",
                CreateTime=DateTime.Now
            };
           var entity= Mapper.Map<UserModel>(user); 
            return  JsonConvert.SerializeObject(entity);
        }

        /// <summary>
        /// 除简单字段转换外指定特殊字段转换
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(GetAppoint))]
        public ActionResult<string> GetAppoint()
        {
            var user = new User()
            {
                Id = 1,
                UserName = "TestUserName",
                PassWord = "TestPassWord",
                CreateTime = DateTime.Now
            };
            var entity = Mapper.Map<UserAppoint>(user);
            return JsonConvert.SerializeObject(entity);
        }

        /// <summary>
        /// 多对一转换
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(GetManyToOne))]
        public ActionResult<string> GetManyToOne()
        {
            var user = new User()
            {
                Id = 1,
                UserName = "TestUserName",
                PassWord = "TestPassWord",
                CreateTime = DateTime.Now
            };
            var userInfo = new UserInfo()
            {
                Phone = "123456789"
            };
            var entity = Mapper.Map<UserInfoModel>(user).Map(userInfo);
            return JsonConvert.SerializeObject(entity);
        }
        /// <summary>
        /// 集合转换
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(GetToList))]
        public ActionResult<string> GetToList()
        {
            var userList = new List<User>() 
            {
                new User()
            {
                Id = 1,
                UserName = "TestUserName1",
                PassWord = "TestPassWord1",
                CreateTime = DateTime.Now
            },
            new User()
            {
                Id = 2,
                UserName = "TestUserName2",
                PassWord = "TestPassWord2",
                CreateTime = DateTime.Now
            },
                new User()
            {
                Id = 3,
                UserName = "TestUserName3",
                PassWord = "TestPassWord3",
                CreateTime = DateTime.Now
            }
        };
            var entity = Mapper.Map<List<UserModel>>(userList);
            return JsonConvert.SerializeObject(entity);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

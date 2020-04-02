﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapperTest.Dto;
using MapperTest.Model;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

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

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
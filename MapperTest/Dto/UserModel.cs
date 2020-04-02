using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapperTest.Dto
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string CreateTime { get; set; }
    }
}

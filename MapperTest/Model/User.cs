using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapperTest.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

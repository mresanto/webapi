using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class UserModel
    {
        public string user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models;

namespace ScholarBarter.Controllers
{
    public class UsersJsonController : ApiController
    {
        User[] users = new User[]
        {
             new User { ID = 1, userName = "Arun", userAddress= "S", phone="1234566" },
             new User { ID = 2, userName = "Domnick", userAddress = "A", phone = "78845545"},
             new User { ID = 3, userName = "Kshitija", userAddress = "S", phone = "6456445" }
        };
          
        public string Get()
        {
            string json = Json.Encode(users);
            return json;
        }
    }
}

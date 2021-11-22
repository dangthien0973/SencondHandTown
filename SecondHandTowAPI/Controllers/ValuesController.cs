using SecondHandTowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecondHandTowAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("getListUser")]
        public List<User> Get()
        {
            List<User> lstUser = new List<User>();
            User user = new User();
            lstUser = user.GetAllUser();
         return lstUser;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("InsertUser")]
        public string Post(User user)
        {
            User userAdd = new User();
            userAdd.UserName = user.UserName;
            userAdd.Passwords = user.Passwords;
            userAdd.Address = user.Address;
            userAdd.Email = user.Email;

            string mess = userAdd.InsertUser();
            return mess;
        }
        

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

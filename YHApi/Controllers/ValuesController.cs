using Newtonsoft.Json;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YHApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        private IUserManager um;
        public ValuesController(IUserManager uManager)
        {
            um = uManager;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var user = um.LoadAll(x=>x.ID>0);
            return JsonConvert.SerializeObject(user);
            
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DashboardTestApi.Controllers
{
    [RoutePrefix("test")]
    public class TestController : ApiController
    {
        // GET: api/test
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test
        [Route("orders")]
        [HttpGet]
        public IEnumerable<string> orders()
        {
            return new string[] { "value3", "value2" };
        }


    }
}

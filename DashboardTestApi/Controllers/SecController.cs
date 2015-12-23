using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DashboardTestApi.Controllers
{
    [RoutePrefix("api/sec")]
    public class SecController : ApiController
    {
        [HttpGet]
        [Route("data")]
        public string GetData()
        {
            return "test data";
        }
    }
}

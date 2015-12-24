using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DashboardTestApi.Account.Model;
using DashboardTestApi.Account.SampleData;

namespace DashboardTestApi.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("getAll")]
        public IEnumerable<AccountDetail> GetAccounts()
        {
            var accountDetails = new AccountDetails();
            return accountDetails.GetSampleData();
        }
    }
}

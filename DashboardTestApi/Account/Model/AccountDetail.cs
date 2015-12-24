using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardTestApi.Account.Model
{
    public class AccountDetail
    {
        public string AccountId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string AccountField1 { get; set; }
        public string AccountField2 { get; set; }
        public string AccountField3 { get; set; }
    }
}
using DashboardTestApi.Account.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashboardTestApi.Account.SampleData
{
    public class AccountDetails
    {
        public IEnumerable<AccountDetail> GetSampleData()
        {
            List<AccountDetail> listAccountDetail = new List<AccountDetail>();
            listAccountDetail.Add(GetAccount("1","account1",true,"field1", "field2", "field3"));
            listAccountDetail.Add(GetAccount("2", "account2", true, "field11", "field21", "field31"));
            listAccountDetail.Add(GetAccount("3", "account3", true, "field21", "field22", "field32"));
            listAccountDetail.Add(GetAccount("4", "account4", true, "field31", "field23", "field33"));
            listAccountDetail.Add(GetAccount("5", "account5", true, "field41", "field24", "field34"));
            listAccountDetail.Add(GetAccount("6", "account6", true, "field51", "field25", "field35"));
            listAccountDetail.Add(GetAccount("7", "account6", true, "field61", "field26", "field36"));

            return listAccountDetail;
        }

        public AccountDetail GetAccount(string id,string name,bool statusInd,string field1,string field2,string field3)
        {
           return new AccountDetail() {
                AccountId = id,
                Name= name,
                Status= statusInd,
                AccountField1 = field1,
                AccountField2= field2,
                AccountField3 = field3
            };
        }

    }
}
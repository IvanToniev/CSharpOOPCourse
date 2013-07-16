using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    class IndividualCustomer:Customer
    {
        
        public IndividualCustomer(Account account,string name)
            :base(name)
        {
            this.Account = account;
        }
        public Account Account
        {
            get
            {
                return this.Account;
            }
            protected set 
            {
                this.Account = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    class LoanAccount:Account
    {
        public LoanAccount(double balance, double intRate,Customer customer)
            : base(balance,intRate,customer)
        { }


        public override double InterestAmount(byte months)
        {
            
            if (this.Customer is IndividualCustomer)
            {
                if (months > 3)
                {
                    return (months - 3) * this.InterestRate;
                }
                else
                { 
                    return 0;
                }
            }
            else if(this.Customer is CompanyCustomer)
            {
                if (months > 2)
                {
                    return (months - 2) * this.InterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}

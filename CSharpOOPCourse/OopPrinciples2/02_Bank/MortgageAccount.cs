using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    class MortgageAccount:Account
    {
        public MortgageAccount(double balance, double intRate,Customer customer)
            : base(balance,intRate,customer)
        { }

        public override double InterestAmount(byte months)
        {

            if (this.Customer is IndividualCustomer)
            {
                if (months > 6)
                {
                    return  this.InterestRate * (months - 6);
                }
                else { return 0; }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months > 12)
                {
                    return this.InterestRate * 6 + this.InterestRate * (months - 12);
                }
                else { return this.InterestRate * months / 2; }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}

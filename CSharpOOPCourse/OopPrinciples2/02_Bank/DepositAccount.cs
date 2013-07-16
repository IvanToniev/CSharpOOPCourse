using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    class DepositAccount:Account
    {
        public void WithdrawMoney(double moneyToTake)
        {
            this.Balance -= moneyToTake;
        }
        public DepositAccount(double balance, double intRate,Customer customer)
            : base(balance,intRate,customer)
        { }

        public override double InterestAmount(byte months)
        {
            if (this.Balance > 0 && this.Balance < 1001)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * months;
            }
        }
    }
}

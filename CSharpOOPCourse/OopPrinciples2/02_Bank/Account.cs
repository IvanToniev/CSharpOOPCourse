using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank
{
    public abstract class Account:IDepositable
    {
        Customer customer;
        private double interestRate;
        private double balance;

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set
            {
                this.customer = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance=value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate=value;
            }
        }

        public Account(double balance,double interestRate,Customer customer)
        {
            this.Balance=balance;
            this.InterestRate=interestRate;
            this.customer = customer;
        }

        public void DepositMoney(double depositMoney)
        {
            this.Balance+=depositMoney;
        }

        public virtual double InterestAmount(byte months)
        {            
            return months*(this.interestRate);
        }
    }
}

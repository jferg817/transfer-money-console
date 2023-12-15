using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__bank_account_
{
    internal class SavingsAccount : Account
    {
        public double interestRate;
        public SavingsAccount(double balance) : base(balance)
        {
            interestRate = 1.05;
        }

        public override void Deposit(double amount)
        {
            balance *= interestRate;
            balance += amount;
            ViewBalance();
        }
    }
}

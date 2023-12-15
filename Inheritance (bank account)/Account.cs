using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__bank_account_
{
    internal class Account
    {
        public double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Current balance is {balance}");
        }

        public  virtual void Deposit(double amount)
        {
            balance += amount;
            ViewBalance();
        }

        public void Withdrawal(double amount)
        {
            balance -= amount;
            ViewBalance();
        }
    }
}

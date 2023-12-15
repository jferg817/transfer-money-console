using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__bank_account_
{
    internal class CheckingAccount : Account
    {
        
        public CheckingAccount(double balance) : base(balance)
        {
            
        }

        public void WriteACheck(double amount, string recipient)
        {
            Console.WriteLine($"Writing a check to {recipient} for {amount}");
            base.Withdrawal(amount);
        }
    }
}

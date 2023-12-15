namespace Inheritance__bank_account_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(500);
            myAccount.Deposit(100);

            SavingsAccount savings = new SavingsAccount(500);
            savings.Deposit(100);

            CheckingAccount checkings = new CheckingAccount(500);
            checkings.WriteACheck(100, "Mary");

            Console.WriteLine("The end");

        }
    }   

}
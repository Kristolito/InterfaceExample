
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Interfaces;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount savingAccount = new SavingAccount();
            IBankAccount currentAccount = new CurrentAccount();

            savingAccount.Deposit(50);
            savingAccount.Withdraw(10);
            savingAccount.ToString();

            currentAccount.Deposit(100);
            currentAccount.Withdraw(50);
            currentAccount.Withdraw(10);
            currentAccount.ToString();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4___Kiet_Tiet
{
    class BankAccount
    {
        private decimal balance;    // Account balance

        public BankAccount(decimal begBalance)
        {
            balance = begBalance;
        }

        public decimal GetBalance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)   // Add up with the deposit amount
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)   //Substract the withdraw amount
        {
            balance -= amount;
        }
    }
}

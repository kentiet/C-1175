using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___In_Class
{
    class BankAccount
    {
        
        private decimal _balance;                   // Backing Field
       
        public BankAccount(decimal startingBalance) // Constructor
        {
            _balance = startingBalance;
        }
       
        public decimal Balance                      // Balance property (read-only)
        {
            get { return _balance; }
        }
     
        public void Deposit(decimal amount)         // Deposit method
        {
            _balance += amount;
        }
     
        public void Withdraw(decimal amount)        // Withdraw method
        {
            _balance -= amount;
        }
    }
}

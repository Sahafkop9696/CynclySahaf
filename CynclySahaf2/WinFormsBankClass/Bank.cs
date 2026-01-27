using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsBankClass
{
    public class Bank
    {
        int Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(int amount)
        {
            Balance = Balance - amount;
        }
    }
}

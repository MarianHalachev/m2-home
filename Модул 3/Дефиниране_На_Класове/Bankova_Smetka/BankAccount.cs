using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankova_Smetka
{
    class BankAccount
    {
        private string nameID;
        private int balance;

        public string NameID
        {
            get { return nameID; }
            set { nameID = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int kolichestvo)
        {
            balance += kolichestvo;
        }

        public void Withdraw(int amount)
        {
            balance -= amount;
        }
    }
}

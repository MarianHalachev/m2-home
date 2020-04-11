using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankova_Smetka
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> account = new List<BankAccount>();

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<BankAccount> Account
        {
            get { return account; }
            set { account = value;}
        }

        public double SumOfBalance()
        {
            return Account.Sum(x => x.Balance);
        }
    }
}

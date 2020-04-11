using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankova_Smetka
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Asen";
            p1.Age = 25;

            BankAccount smetka1 = new BankAccount();
            smetka1.NameID = "BNB";
            smetka1.Balance = 1000;
            p1.Account.Add(smetka1);

            BankAccount smetka2 = new BankAccount();
            smetka2.NameID = "OBB";
            smetka2.Balance = 2000;
            p1.Account.Add(smetka2);

            BankAccount smetka3 = new BankAccount();
            smetka3.NameID = "FB";
            smetka3.Balance = 3000;
            p1.Account.Add(smetka3);

            foreach (var item in p1.Account)
            {
                Console.WriteLine($"{item.NameID}->{item.Balance} lv.");
            }
            Console.WriteLine(p1.SumOfBalance());

            smetka1.Deposit(200);
            foreach (var item in p1.Account)
            {
                Console.WriteLine($"{item.NameID}->{item.Balance} lv.");
            }
            Console.WriteLine(p1.SumOfBalance());

            smetka1.Withdraw(500);
            foreach (var item in p1.Account)
            {
                Console.WriteLine($"{item.NameID}->{item.Balance} lv.");
            }
            Console.WriteLine(p1.SumOfBalance());
        }
    }
}

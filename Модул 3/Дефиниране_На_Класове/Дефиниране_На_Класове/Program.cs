using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дефиниране_На_Класове
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;

            //Console.WriteLine($"Ime: {p1.Name} || Godini: {p1.Age}");

            Person p2 = new Person();
            p2.Name = "Georgi";
            p2.Age = 41;

            //Console.WriteLine($"Ime: {p2.Name} || Godini: {p2.Age}");
            //Console.WriteLine(p1.IntroduceYourself());
            //Console.WriteLine(p2.IntroduceYourself());

            p1.I_Am();

        }
    }
}

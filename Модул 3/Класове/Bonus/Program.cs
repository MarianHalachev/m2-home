using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i <br; i++)
            {
                try
                {
                    var line = Console.ReadLine().Split(' ').ToList();
                    Person p = new Person(line[0], line[1], int.Parse(line[2]), double.Parse(line[3]));
                    people.Add(p);
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                }
               
            }

            

           
            double percentBonus =  double.Parse(Console.ReadLine());
            Console.WriteLine("====================");
            people.ForEach(p => p.SalaryBonus(percentBonus));

            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName}, {item.SecondName}, {item.Age}, gets {item.Salary} leva");
            }
        }
    }
}

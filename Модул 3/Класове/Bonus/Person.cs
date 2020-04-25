using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    class Person
    {
        private string firstname;
        private string secondname;
        private int age;
        private double salary;

        public Person(string firstname, string secondname, int age, double salary)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("First name can't be less than 3 symbols");
                }
                firstname = value;
            }
            
        }

        public string SecondName
        {
            get { return secondname; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Second name can't be less than 3 symbols");
                }
                secondname = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value<1)
                {
                    throw new ArgumentException("Age can't be less than one");
                }
                age = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value<460)
                {
                    throw new ArgumentException("Salary can't be less than 460");
                }
                salary = value;
            }
        }

        public void SalaryBonus(double percent)
        {
            if (age>30)
            {
                salary += salary * percent / 100;
            }
            else
            {
                salary += salary * percent / 200;
            }
        }

    }
}

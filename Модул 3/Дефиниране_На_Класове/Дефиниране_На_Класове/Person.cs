﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дефиниране_На_Класове
{
    class Person
    {
        private string name;
        private int age;

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

        public string IntroduceYourself()
        {
            return $"I am {name}, {age} years old";
        }

        public void I_Am()
        {
            Console.WriteLine($"I am {name}, {age} years old");
        }

    }
}

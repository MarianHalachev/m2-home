using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Chicken(string name, int age)
        {
            
                if (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name))
	            {
                    throw new ArgumentException("Name can't be empty");
                }
                this.name = name;
                this.age = age;
            
        }

        public string CalculateProductPerDay()
        {
            if (age> 15 ||age<0)
            {
                throw new ArgumentException("Age should be between 0 and 15");
            }
            return $"chicken {name} (age {age}) can produce eggs per day";
        }

    }
}

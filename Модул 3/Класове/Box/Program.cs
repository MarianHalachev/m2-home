using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Box1 p = new Box1(a,b,c);

            Console.WriteLine($"Obemut e: {p.Obem()}");

            Console.WriteLine($"Okolnata obilkolka e: {p.OkolnaObikolka()}");

            Console.WriteLine($"Pulnata obikolka e: {p.PulnaObikolka()}");
        }
    }
}

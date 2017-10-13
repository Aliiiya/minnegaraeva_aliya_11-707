using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, mult = 1;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                mult *= a;
            }
            Console.WriteLine(a % 10);
            Console.ReadLine();
        }
    }
}

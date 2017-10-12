using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    k = k + 1;
                }
                n = n / 2;
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}

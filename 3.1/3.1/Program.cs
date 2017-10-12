using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, a1, b1, nok;
            Console.WriteLine("Введите количество чисел");
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                a1 = a;
                b1 = b;
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
                nok = a1 * b1 / a;
                a = nok;
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

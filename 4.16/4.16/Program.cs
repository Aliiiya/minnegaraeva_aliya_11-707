using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, kMax = 0, k1 = 0, s = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int m = i; s <= n; m++)
                {
                    s += m;
                    k1++;
                    if (s == n)
                        k = k1;
                }
                if (k > kMax)
                    kMax = k;
                s = 0;
                k1 = 0;
            }
            Console.WriteLine(kMax);
            Console.ReadLine();
        }
    }
}

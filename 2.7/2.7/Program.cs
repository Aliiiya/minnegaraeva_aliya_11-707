using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, d, sk = 0, ks, s = 0;
            for (i = 1; i <= 100; i++)
            {
                sk += i * i;
                s += i;
            }
            ks = s * s;
            d = sk - ks;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}

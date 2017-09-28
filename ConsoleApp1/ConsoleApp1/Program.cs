using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, k;
            m = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            while ((m != 0) && (k != 0))
            {
                if (m > k)
                {
                    m = m % k;
                }
                else
                {
                    k = k % m;
                }
            }
            Console.WriteLine(k + m);
            Console.ReadLine();
        }
    }
}

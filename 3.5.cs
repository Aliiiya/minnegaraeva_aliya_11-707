using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                x = Math.Cos(x);
            }
                Console.WriteLine(x);
        }
    }
}

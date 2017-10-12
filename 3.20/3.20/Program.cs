using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = -1, sEven = 0, sOdd = 0;
            int kEven = 0, kOdd = 0;
            while (n != 0)
            {
                n = double.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    sEven += n;
                    ++kEven;                   
                }
                else
                {
                    sOdd += n;
                    ++kOdd;
                }
            }
            if (kEven > kOdd)
                Console.WriteLine(sEven);
            else Console.WriteLine(sOdd);
            Console.ReadLine();
        }
    }
}

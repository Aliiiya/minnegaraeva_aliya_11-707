using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string a;
            Console.WriteLine("Введите координаты шахматной доски");
            i = int.Parse(Console.ReadLine());
            a = Console.ReadLine();
            if (i % 2 == 1)
                if ((a == "a") || (a == "c") || (a == "e") || (a == "g"))
                    Console.WriteLine("BLACK");
                else Console.WriteLine("WHITE");
            else
            {
                if ((a == "a") || (a == "c") || (a == "e") || (a == "g"))
                    Console.WriteLine("WHITE");
                else Console.WriteLine("BLACK");
            }
            Console.ReadLine();
        }
    }
}

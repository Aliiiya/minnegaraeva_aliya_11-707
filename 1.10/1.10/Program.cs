using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("Введите коэффициент a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            c = double.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if ((a == 0) && (b == 0) && (c == 0))
                Console.WriteLine("-1");
            else if (a == 0)
                Console.WriteLine($"1 корень, который равен {-c / b}");
            else if (d == 0)
                Console.WriteLine($"1 корень, который равен {-b / (2 * a)}");
            else if (d > 0)
                Console.WriteLine($"2 корня, которые равны {(-b + Math.Sqrt(d)) / (2 * a)} и {(-b - Math.Sqrt(d)) / (2 * a)}");
            else Console.WriteLine("Корней нет");            
            Console.ReadLine();
        }
    }
}

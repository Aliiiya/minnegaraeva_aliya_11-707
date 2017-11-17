using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, x, result = 0, previousResult = 0, sum = 0;
            int k = 0;
            Console.WriteLine("Введите e");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            previousResult = result + e + 1;
            while (Math.Abs(result - previousResult) > e)
            {
                previousResult = result;
                result = Result(x, k);
                sum = Sum(sum, result);
                k++;
            }
            Console.WriteLine($"{sum} на {k} шаге");
        }
        static double Result(double x, int k)
        {
            double factorial2k = 1, powx = 1;
            for (int i = 1; i <= 2 * k + 1; i++)
            {
                powx *= x;
                factorial2k *= i;
            }
            double result = powx / factorial2k;
            return result;
        }
        static double Sum(double sum, double result)
        {
            sum += result;
            return sum;
        }
    }
}

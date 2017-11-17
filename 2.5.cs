using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, result = 0, previousResult, sum = 0;
            int k = 1;
            Console.WriteLine("Введите e");
            e = double.Parse(Console.ReadLine());
            previousResult = result + e + 1;
            while (Math.Abs(result - previousResult) > e)
            {
                previousResult = result;
                result = Result(k);
                sum = Sum(sum, result);
                k++;
            }
            Console.WriteLine(-2 + 2 * sum);
        }
        static double Result(int k)
        {
            double factorialk = 1, pow2 = 1, factorial2k = 1;
            for (int i = 1; i <= k; i++)
            {
                pow2 *= 2;
                factorialk *= i;
            }
            for (int i = 1; i <= 2*k; i++)
            {
                factorial2k *= i;
            }
            double result = pow2 / (factorial2k / (factorialk * factorialk));
            return result;
        }
        static double Sum(double sum, double result)
        {
            sum += result;
            return sum;
        }
    }
}

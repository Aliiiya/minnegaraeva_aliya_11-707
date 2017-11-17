using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double h = 2.0 / n;
            Console.WriteLine("Метод левых прямоугольников " + LeftRectanglesMethod(n, h));
            Console.WriteLine("Метод левых прямоугольников " + RightRectanglesMethod(n, h));
            Console.WriteLine("Метод трапеций " + TrapezeRectanglesMethod(n, h));
            if (n % 2 == 0)
                Console.WriteLine("Метод Симпсона " + SimpsonsMethod(n, h));
            Console.WriteLine("Метод Монте-Карло " + MonteCarloMethod(n));
        }
        static double LeftRectanglesMethod(int n, double h)
        {
            double function = 0, value = -1;
            for (int i = 0; i < n; i++)
            {
                function += Math.Cos(Math.Tan(value));
                value += h;
            }
            return h * function;
        }
        static double RightRectanglesMethod(int n, double h)
        {
            double function = 0, value = -1 + h;
            for (int i = 0; i < n; i++)
            {
                function += Math.Cos(Math.Tan(value));
                value += h;
            }
            return h * function;
        }
        static double TrapezeRectanglesMethod(int n, double h)
        {
            double function = 0, value = -1 + h;
            for (int i = 0; i < n; i++)
            {
                function += (Math.Cos(Math.Tan(value)) + Math.Cos(Math.Tan(value - h))) / 2;
                value += h;
            }
            return h * function;
        }
        static double SimpsonsMethod(int n, double h)
        {
            double function = 0, value = -1 + h;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                    function += 2 * Math.Cos(Math.Tan(value));
                else
                    function += 4 * Math.Cos(Math.Tan(value));
                value += h;
            }
            function += Math.Cos(Math.Tan(-1)) + Math.Cos(Math.Tan(1));
            return h * function / 3;
        }
        static double MonteCarloMethod(int n)
        {
            Random r = new Random();
            double x, s = 0;
            for (int i = 0; i < n; i++)
            {
                x = -1 + r.NextDouble() * 2;
                s += Math.Cos(Math.Tan(x));
            }
            return s * 2 / n;
        }
    }
}

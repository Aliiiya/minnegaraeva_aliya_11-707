using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            int n = int.Parse(Console.ReadLine());
            h = 1.5 / n;
            Console.WriteLine("Метод левых прямоугольников " + LeftRectanglesMethod(n, h));
            Console.WriteLine("Метод правых прямоугольников " + RightRectanglesMethod(n, h));
            Console.WriteLine("Метод трапеций " + TrapezeRectanglesMethod(n, h));
            if (n % 2 == 0)
                Console.WriteLine("Метод Симпсона " + SimpsonsMethod(n, h));
            Console.WriteLine("Метод Монте-Карло " + MonteCarloMethod(n));
        }
        static double LeftRectanglesMethod(int n, double h)
        {
            double function = 0, value = 0;
            for (int i = 0; i < n; i++)
            {
                function += Math.Sin(2 * value) / (Math.Cos(value) * Math.Cos(value));
                value += h;
            }
            return h * function;
        }
        static double RightRectanglesMethod(int n, double h)
        {
            double function = 0, value = h;
            for (int i = 0; i < n; i++)
            {
                function += Math.Sin(2 * value) / (Math.Cos(value) * Math.Cos(value));
                value += h;
            }
            return h * function;
        }
        static double TrapezeRectanglesMethod(int n, double h)
        {
            double function = 0, value = h;
            for (int i = 0; i < n; i++)
            {
                function += (Math.Sin(2 * value) / (Math.Cos(value) * Math.Cos(value)) + Math.Sin(2 * (value - h)) / (Math.Cos(value - h) * Math.Cos(value - h))) / 2;
                value += h;
            }
            return h * function;
        }
        static double SimpsonsMethod(int n, double h)
        {
            double function = 0, value = h;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                    function += 2 * Math.Sin(2 * value) / (Math.Cos(value) * Math.Cos(value));
                else
                    function += 4 * Math.Sin(2 * value) / (Math.Cos(value) * Math.Cos(value));
                value += h;
            }
            function += Math.Sin(1.5) / (Math.Cos(1.5) * Math.Cos(1.5));
            return h * function / 3;
        }
        static double MonteCarloMethod(int n)
        {
            Random r = new Random();
            double x, s = 0;
            for (int i = 0; i < n; i++)
            {
                x = r.NextDouble() * 1.5;
                s += Math.Sin(x) / (Math.Cos(x) * Math.Cos(x));
            }
            return s / (n * 1.5);
        }
    }
}

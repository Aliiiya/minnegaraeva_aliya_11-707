using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr8
{
    class Program
    {
        static void Main(string[] args)
        {
            double lx1, ly1, lx2, ly2, ax, ay, px, py, a, b, c, p, s, h, p1, p2, t;
            Console.WriteLine("Введите координаты двух точек на прямой L");
            Console.WriteLine("x1");
            lx1 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1");
            ly1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2");
            lx2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2");
            ly2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки A");
            Console.WriteLine("x");
            ax = double.Parse(Console.ReadLine());
            Console.WriteLine("y");
            ay = double.Parse(Console.ReadLine());
            //a, b, c - стороны треугольника, сторона a - отрезок прямой
            a = Math.Sqrt((lx1 - lx2) * (lx1 - lx2) + (ly1 - ly2) * (ly1 - ly2));
            b = Math.Sqrt((ax - lx2) * (ax - lx2) + (ay - ly2) * (ay - ly2));
            c = Math.Sqrt((lx1 - ax) * (lx1 - ax) + (ly1 - ay) * (ly1 - ay));
            //p - полупериметр треугольника
            p = (a + b + c) / 2;
            //s - площадь треугольника
            s = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            //h - высота треугольника - перпендикуляр к прямой
            h = (2 * s) / a;
            //p1 - расстояние от точки пересечения прямой и перпендикуляра до первой точки прямой
            p1 = Math.Sqrt(c * c - h * h);
            //p2 - расстояние от точки пересечения прямой и перпендикуляра до второй точки прямой
            p2 = Math.Sqrt(b * b - h * h);
            //Дальше по формуле
            //Если точка лежит ближе к левому краю отрезка
            if (c < b)
            {
                t = p2 / a;
                px = lx2 + t * (lx1 - lx2);
                py = ly2 + t * (ly1 - ly2);
            }
            //Если точка равноудалена или лежит ближе к правому краю отрезка
            else
            {
                t = p1 / a;
                px = lx1 + t * (lx2 - lx1);
                py = ly1 + t * (ly2 - ly1);
            }
            Console.WriteLine("(" + px + "; " + py + ")");
            Console.ReadLine();
        }
    }
}

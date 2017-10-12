using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._15
{
    class Program
    {
        public static void Null(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("0");
            }
        }
        public static void One(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("1");
            }
        }
        public static void Two(int a, int b)
        {
            if (a == 2)
            {
                if ((b % 2 == 0) && (b % 4 != 0))
                {
                    Console.WriteLine("4");
                }
                else
                {
                    if (b % 4 == 0)
                    {
                        Console.WriteLine("6");
                    }
                    else
                    {
                        if (((b - 1) % 2 == 0) && ((b - 1) % 2 != 0))
                        {
                            Console.WriteLine("8");
                        }
                        else
                        {
                            Console.WriteLine("2");
                        }
                    }
                }
            }
        }
        public static void Three(int a, int b)
        {
            if (a == 3)
            {
                if ((b % 2 == 0) && (b % 4 != 0))
                {
                    Console.WriteLine("9");
                }
                else
                {
                    if (b % 4 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        if (((b - 1) % 2 == 0) && ((b - 1) % 2 != 0))
                        {
                            Console.WriteLine("7");
                        }
                        else
                        {
                            Console.WriteLine("3");
                        }
                    }
                }
            }
        }
        public static void Four(int a, int b)
        {
            if (a == 4)
            {
                if (b % 2 == 0)
                    Console.WriteLine("6");
                else
                {
                    Console.WriteLine("4");
                }
            }
        }
        public static void Five(int a)
        {
            if (a == 5)
            {
                Console.WriteLine("5");
            }
        }
        public static void Six(int a)
        {
            if (a == 6)
            {
                Console.WriteLine("6");
            }
        }
        public static void Seven(int a, int b)
        {
            if (a == 7)
            {
                if ((b % 2 == 0) && (b % 4 != 0))
                {
                    Console.WriteLine("9");
                }
                else
                {
                    if (b % 4 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        if (((b - 1) % 2 == 0) && ((b - 1) % 2 != 0))
                        {
                            Console.WriteLine("3");
                        }
                        else
                        {
                            Console.WriteLine("7");
                        }
                    }
                }
            }
        }
        public static void Eight(int a, int b)
        {
            if (a == 8)
            {
                if ((b % 2 == 0) && (b % 4 != 0))
                {
                    Console.WriteLine("4");
                }
                else
                {
                    if (b % 4 == 0)
                    {
                        Console.WriteLine("6");
                    }
                    else
                    {
                        if (((b - 1) % 2 == 0) && ((b - 1) % 2 != 0))
                        {
                            Console.WriteLine("2");
                        }
                        else
                        {
                            Console.WriteLine("8");
                        }
                    }
                }
            }
        }
        public static void Nine(int a, int b)
        {
            if (a == 9)
            {
                if (b % 2 == 0)
                    Console.WriteLine("1");
                else
                {
                    Console.WriteLine("9");
                }
            }
        }

        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a % 10;
            if (b == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Null(a);
                One(a);
                Two(a, b);
                Three(a, b);
                Four(a, b);
                Five(a);
                Six(a);
                Seven(a, b);
                Eight(a, b);
                Nine(a, b);
            }
            Console.ReadLine();
        }
    }
}

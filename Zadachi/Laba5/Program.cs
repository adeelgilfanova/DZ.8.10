using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA5
{
    class Program
    {
        private static int MaxOfNum()
        {
            Console.WriteLine("Введите 1 число: ");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            int chislo2 = int.Parse(Console.ReadLine());
            return Math.Max(chislo1, chislo2);
        }

        public static void SwapOfnum(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Теперь 1 число = {a}, a 2  число = {b}");

        }
        static bool fact(ref int num)
        {
            int y = num;
            num = 1;
            for (int i = 1; i <= y; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }
        static int Factorial(int B)
        {
            if (B == 0) return 1;
            return B * Factorial(B - 1);
        }
        private static int[] memF = new int[100];
        private static int Fib(int n)
        {
            if (n <= 1) return n;

            if (memF[n] != 0) return memF[n];

            memF[n] = Fib(n - 2) + Fib(n - 1);
            return memF[n];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" \n Упр1");
            Console.WriteLine("Максимальное число: " + MaxOfNum());
            Console.ReadKey();

            Console.WriteLine(" \n Упр2");
            Console.WriteLine("Введите 1 число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"1 число = {a}, 2 число = {b}");
            Console.WriteLine("Теперь поменяем из местами!");
            SwapOfnum(ref a, ref b);
            Console.ReadKey();

            Console.WriteLine(" \n Упр3");
            Console.WriteLine("Введите число х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool flag = fact(ref x);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(x));

            Console.WriteLine("Упр4");
            Console.WriteLine("Введите число, которое хотите возвести в факториал: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал числа B =" + Factorial(B));

            Console.WriteLine("\n ДЗ.1");
            Console.WriteLine("Введите 1 число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i > 0; i--)
            {
                if (num1 % i == 0)
                {
                    if (num2 % i == 0)
                    {
                        if (num3 % i == 0)
                        {

                            Console.WriteLine($"НОД 3 чисел= {i}");
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("ДЗ.2");
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение n-го числа Фибоначчи: " + Fib(n));
            Console.ReadKey();
        }
    }
}


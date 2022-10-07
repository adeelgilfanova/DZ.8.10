using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    enum UrVorchk
    {
        милашка=0,
        немилашка=1,
        bitch=2,
        super_bitch=3
    }
    struct Ded
    {
        public string name;
        public byte UrVorchk;
        public string[] Prasi;
        public byte Sinyaki;
        public Ded(string name, byte UrVorchk, string[] Prasi, byte Sinyaki)
        {
            this.name = name;
            this.UrVorchk = UrVorchk;
            this.Prasi = Prasi;
            this.Sinyaki = Sinyaki;
        }
    }
    class QuickSorting
    {
        public static void sorting(double[] arr, long first, long last)
        {
            double p = arr[(last - first) / 2 + first];// ищем средний элемент
            double temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
        }
    }
    class Program
    {
        public static void KvadrUrav(double a, double b, double c)
        {
            double D;
            double x1;
            double x2;
            double x;
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                x1 = ((-b + Math.Sqrt(b)) / 2 * a);
                x2 = ((-b - Math.Sqrt(b)) / 2 * a);
                Console.WriteLine($"1 корень = {x1}, 2 корень = {x2}");
            }
            else if (D == 0)
            {
                x = (-b / 2 * a);
                Console.WriteLine($"Единственный корень = {x}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        public static void ProizVandSrArifm(ref int proizvidenie, out int SrArifm, params int[] masOfNumb)
        {
            proizvidenie = 1;
            for (int i = 0; i < masOfNumb.Length; i++)
            {
                proizvidenie = proizvidenie * masOfNumb[i];
            }
            Console.WriteLine("Произведение элементов массива = " + proizvidenie);
            int sum = 0;
            for (int i = 0; i < masOfNumb.Length; i++)
            {
                sum = sum + masOfNumb[i];
            }
            SrArifm = sum / (masOfNumb.Length);
            Console.WriteLine("Средне арифмитечское элементов массива = " + SrArifm);
        }
        private static int Sum(params int[] masOfNumb)
        {
            int sum = 0;
            for (int i = 0; i < masOfNumb.Length; i++)
            {
                sum = sum + masOfNumb[i];
            }
            return sum;
        }
        static byte Sinyaki(Ded ded, params string[] array)
        {
            foreach (string i in ded.Prasi)
            {
                if (array.Contains(i))
                {
                    ded.Sinyaki += 1;
                }
            }
            return ded.Sinyaki;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание1 Решение квадратного уравнения");
            Console.WriteLine("Введите 1 коэффицент(а)");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 коэффицент(b)");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 коэффицент(c)");
            double c = double.Parse(Console.ReadLine());
            KvadrUrav(a, b, c);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("\nЗадание2");
            int[] massOfCount = new int[20];
            Random rand = new Random();
            for (int u = 0; u < massOfCount.Length; u++)
            {
                massOfCount[u] = rand.Next(0, 100);
            }
            int[] massOfCount2 = new int[20];
            for (int i = 0; i < massOfCount.Length; i++)
            {
                massOfCount2[i] = massOfCount[i];
            }
            var mas = string.Join(" ", massOfCount);
            Console.WriteLine("Массив: " + mas);
            Console.WriteLine("Введите 2 числа из массива которые хотите поменять: ");
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());
            int index1 = massOfCount2.findIndex(chislo1);
            int index2 = massOfCount2.findIndex(chislo2);
            int index = massOfCount2[index1];
            massOfCount2[index1] = massOfCount2[index2];
            massOfCount2[index2] = index;
            var mas2 = string.Join(" ", massOfCount2);
            Console.WriteLine("Переделанный массив: " + mas2);
            Console.ReadKey();

            Console.WriteLine("\nЗадание3 Сортировка массива");
            Console.WriteLine("Введите количество элементов массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas0 = new int[N];
            for (int i = 0; i < mas0.Length; i++)
            {
                mas0[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas0);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas0.Length; i++)
            {
                Console.WriteLine(mas0[i]);
            }
            Console.ReadLine();

            Console.WriteLine("\nЗадание4 Массивчик");
            Console.WriteLine("Введите количество элементов массива:");
            int Q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для массива:");
            int[] masOfNumb = new int[Q];
            for (int i = 0; i < masOfNumb.Length; i++)
            {
                masOfNumb[i] = Convert.ToInt32(Console.ReadLine());
            }
            int proizvidenie = 1;
            int SrArifm = 0;
            ProizVandSrArifm(ref proizvidenie, out SrArifm, masOfNumb);
            Console.WriteLine("Сумма элементов массива = " + Sum(masOfNumb));
            Console.ReadKey();

            Console.WriteLine("\nЗадание5");
            Console.WriteLine("Введите число либо завершите программу: ");
            int chisloo = int.Parse(Console.ReadLine());
            if (chisloo == 0)
            {
                try
                {
                    Console.WriteLine("Введите число: ");
                    int chislo = int.Parse(Console.ReadLine());
                    if (chislo >= 0 & chislo <= 9)
                    {
                        if (chislo == 0)
                        {
                            Console.WriteLine("  ##");
                            Console.WriteLine(" #  #");
                            Console.WriteLine("#    #");
                            Console.WriteLine(" #  #");
                            Console.WriteLine("  ##");
                        }
                        else if (chislo == 1)
                        {
                            Console.WriteLine("  #");
                            Console.WriteLine(" ##");
                            Console.WriteLine("# #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                        }
                        else if (chislo == 2)
                        {
                            Console.WriteLine("  # # #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("   #");
                            Console.WriteLine("  #");
                            Console.WriteLine(" # # # #");
                        }
                        else if (chislo == 3)
                        {
                            Console.WriteLine("  # #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   #");
                            Console.WriteLine("    #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("  # #");
                        }
                        else if (chislo == 4)
                        {
                            Console.WriteLine("#   #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("# # #");
                            Console.WriteLine("    #");
                            Console.WriteLine("    #");
                            Console.WriteLine("    #");
                        }
                        else if (chislo == 5)
                        {
                            Console.WriteLine("# # #");
                            Console.WriteLine("#");
                            Console.WriteLine("#  #");
                            Console.WriteLine("    #");
                            Console.WriteLine("     #");
                            Console.WriteLine("# # #");
                        }
                        else if (chislo == 6)
                        {
                            Console.WriteLine("# # #");
                            Console.WriteLine("#");
                            Console.WriteLine("# #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("#    #");
                            Console.WriteLine("#  #  #");
                        }
                        else if (chislo == 7)
                        {
                            Console.WriteLine("# # # #");
                            Console.WriteLine("     #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   #");
                            Console.WriteLine("  #");
                            Console.WriteLine(" #");
                        }
                        else if (chislo == 8)
                        {
                            Console.WriteLine("   # #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine(" #     #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine("    #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine(" #     #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine("   # #");
                        }
                        else if (chislo == 9)
                        {
                            Console.WriteLine("    # #");
                            Console.WriteLine("   #   #");
                            Console.WriteLine("  #     #");
                            Console.WriteLine("   #   #");
                            Console.WriteLine("     #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   # ");
                            Console.WriteLine("  #");
                        }

                    }
                    else if (chislo < 0 || chislo > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка при выполнение запроса!");
                        System.Threading.Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Это не число!");
                }
            }
            else
            {
                Console.WriteLine("Напишите закрыть или exit: ");
                string exite = Console.ReadLine();
                if (exite == "exit" || exite == "закрыть")
                {
                    Environment.Exit(0);
                }
            }
            string[] q1 = { "проституки", "Гады!" };
            Ded ded1 = new Ded("Тимофей Тимошевич", 1, q1, 0);
            string[] q2 = { "проституты", "одноклеточные", "агузок", "бляди" };
            Ded ded2 = new Ded("Сергей Михайлович", 2, q2, 0);
            string[] q3 = { "проституки", "лентяи", "фашисты", "идиоты" };
            Ded ded3 = new Ded("Петр Петрович", 3, q3, 0);
            string[] q4 = { "Гады", "ебалаи", "бестолочи" };
            Ded ded4 = new Ded("Иван Степанович", 1, q4, 0);
            string[] q5 = { "проституки", "дебилы", "сучки-крашенные" };
            Ded ded5 = new Ded("Алексей Семенович", 0, q5, 0);
            string[] slova = { "проституки", "проституты", "Гады!", "бестолочи", "сучки-крашенные", "дебилы", "идиоты", "бляди" };
            int n1 = 1;
            double n2 = 1;
            Console.WriteLine("\nЗадание6 Дед получает звиздюлей от бабки!");
            Console.WriteLine("Количество звиздюлей деда от бабки: " + Sinyaki(ded1, slova));
            Console.WriteLine("Количество звиздюлей деда от бабки: " + Sinyaki(ded2, slova));
            Console.WriteLine("Количество звиздюлей деда от бабки: " + Sinyaki(ded3, slova));
            Console.WriteLine("Количество звиздюлей деда от бабки: " + Sinyaki(ded4, slova));
            Console.WriteLine("Количество звиздюлей деда от бабки: " + Sinyaki(ded5, slova));
            Console.ReadKey();

            Console.WriteLine("\nЗадание7 Быстрая сортировка");
            double[] arr = new double[10];//указываем кол-во элементов массива

            //заполняем массив случайными числами
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(1, 101);
            }
            Console.WriteLine("Массив перед сортировкой:");
            foreach (double x5 in arr)
            {
                Console.WriteLine(x5 + " ");
            }

            //сортировка
            QuickSorting.sorting(arr, 0, arr.Length - 1);
            Console.WriteLine("\n\nМассив после сортировки:");
            foreach (double x5 in arr)
            {
                Console.WriteLine(x5 + " ");
            }
            Console.ReadLine();
        }

    }
}

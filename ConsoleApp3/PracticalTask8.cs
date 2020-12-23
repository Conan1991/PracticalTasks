using System;

namespace ConsoleApp3
{
    class PracticalTask8
    {
        static void Main(string[] args)
        {
            //task1While();
            //task1DoWhile();
            //task2();
            task3();
        }

        public static void task1DoWhile()
        {
            double a = 0;
            double average = 0;
            double sum = 0;
            double count = 0;
            Console.WriteLine("Введите числа");
            do  {
                a = double.Parse(Console.ReadLine() ?? string.Empty);
                sum += a;
                count++;
            }
            while (a >= 3) ;


            average = sum / count;

            Console.WriteLine("Среднее арифметическое значение = {0}, количество чисел = {1}", average, count);
        }

        public static void task1While()
        {
            double a = 5;
            double average = 0;
            double sum = 0;
            double count = 0;
            Console.WriteLine("Введите числа");
            while (a >= 3)
            {
                a = double.Parse(Console.ReadLine() ?? string.Empty);
                sum += a;
                count++;
            }


            average = sum / count;

            Console.WriteLine("Среднее арифметическое значение = {0}, количество чисел = {1}", average, count);
        }


        public static void task2()
        {
            //double x = 1.5;
            double dx = 0.5;
            double y;
            double u;
            for (double x=1.5;x<=3.5; x+=dx)
            {
                u = Math.Log10(x) * (2.35 * Math.Pow(x + 1, x) + 2 * x);
                y = Math.Pow(Math.Cos(x / 3 / u), 2);
                Console.WriteLine("u = {0} , y = {1}", u, y);
            }
        }
        public static void task3()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            for (int i = 2; i <= n; ++i)
            {
                if(IsPrime(i))
                    Console.Write("\t" + i);
            }
        }

        public static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int limit = (int) Math.Floor(Math.Sqrt(n));
            for (int i = 3; i <= limit; i+=2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}

using System;
using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp2
{
    class PracticalTask10
    {
        static void Main(string[] args)
        {
            //task1();
            task2();
        }

        static void task1()
        {
            double x, y, a;

            //a = 10.25d; 
            Console.Write("Введите значение a: " + Environment.NewLine);
            a = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
            x = Math.Abs(Math.Sin(a));
            if (a*x <= 1)
            {
                y = 0;
                Console.WriteLine("Значение функции = {0}", y);
            }
            else if(a*x > 1 && a*x < 5)
            {
                y = Math.Exp(x - a);
                Console.WriteLine("Значение функции = {0}", y);
            }
            else if(a*x >= 5)
            {
                y = Math.Log10(a - x);
                Console.WriteLine("Значение функции = {0}", y);
            }
        }

        static void task2()
        {
            Console.Write("Введите значение номера набора данных: " + Environment.NewLine);
            int num = int.Parse(Console.ReadLine() ?? string.Empty);
            double res;

            switch (num)
            {
                case 1:
                    Console.Write("Введите значение стороны ромба: " + Environment.NewLine);
                    double a = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectNumber(a, "сторона"))
                        break;
                    Console.Write("Введите значение высоты ромба: " + Environment.NewLine);
                    double h = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectNumber(h, "высота"))
                        break;
                    res = a * h;
                    Console.Write("Площадь ромба: " + res + Environment.NewLine);
                    break;
                case 2:
                    Console.Write("Введите значение стороны ромба: " + Environment.NewLine);
                    double b = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectNumber(b, "сторона"))
                        break;
                    Console.Write("Введите значение угла между сторонами ромба: " + Environment.NewLine);
                    double alpha = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectAngle(alpha))
                        break;
                    res = Math.Pow(b, 2) * Math.Sin(alpha);
                    Console.Write("Площадь ромба: " + res + Environment.NewLine);
                    break;
                case 3:
                    Console.Write("Введите значение первой диагонали ромба: " + Environment.NewLine);
                    double d1 = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectNumber(d1, "диагональ"))
                        break;
                    Console.Write("Введите значение второй диагонали ромба: " + Environment.NewLine);
                    double d2 = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
                    if (!IsCorrectNumber(d2, "диагональ"))
                        break;
                    res = (d1 * d2) / 2;
                    Console.Write("Площадь ромба: " + res + Environment.NewLine);
                    break;
            }
        }

        public static bool IsCorrectNumber(double a, string par)
        {
            if (a <= 0)
            {
                Console.Write("Вы ввели неверное значение параметра " + par + Environment.NewLine);
                return false;
            }

            return true;
        }

        public static bool IsCorrectAngle(double angle)
        {
            if (angle <= 0 || angle >= Math.PI)
            {
                Console.Write("Вы ввели неверное значение угла " + Environment.NewLine);
                return false;
            }

            return true;
        }
    }
}

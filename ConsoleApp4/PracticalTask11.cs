using System;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
           // task2();
           task3();
        }

        static void task1()
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder(s);
            int counter = 0;
            for (int i = 0; i < sb.Length; i++)
                if (char.IsDigit(sb[i]))
                    counter++;
            if(counter == 0 )
                Console.WriteLine("В строке нет цифр");
            else
            {
                Console.WriteLine("В строке {0} цифр(ы)" , counter);
            }
        }

        static void task2()
        {
            Console.WriteLine("Введите предложение:");
            string s = Console.ReadLine();
            Console.WriteLine("Введите цифру:");
            string num = Console.ReadLine() ?? string.Empty;

            string[] strings = s.Split(" ");
            foreach (string str in strings)
            {
                if(str.Contains(num))
                    Console.Write( str + "\t");
            }
        }

        static void task3()
        {
            Console.WriteLine("Введите предложение:");
            string s = Console.ReadLine();
            string[] strings = s.Split(" ");
            StringBuilder sb = new StringBuilder();
            foreach (string str in strings)
            {
                sb.Append(reverse(str));
                sb.Append(" ");
            }
            Console.WriteLine("Предложение с перевернутыми словами:");
            Console.WriteLine(sb.ToString());

        }

        static string reverse(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            string res = "";
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                res += sb[i];
            }

            char punct;
            if (char.IsPunctuation(punct = res.First()))
            {
                res = new StringBuilder(res).Remove(0, 1).Append(punct).ToString();
            }

            return res;
        }
    }
}

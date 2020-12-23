using System;
using System.Linq;

namespace ConsoleApp5
{
    class PracticalTask11
    {
        private static int N;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            N = int.Parse(Console.ReadLine() ?? string.Empty);
            int[] arr = new int[N];
            Console.WriteLine("Введите массив:");
            ReadArray(arr);
            Console.WriteLine("Получен массив:");
            PrintArray(arr);

            //task1(arr);
            //task2(arr);
            task3(arr);
        }

        static void task1(int[] arr)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num >= 0 && num <= 5)
                    count++;
            }
            if(count != 0 )
                Console.WriteLine("Количество элементов в интравале [0,5] = {0}", count);
            else Console.WriteLine("Нет элементов в интравале [0,5]");
        }

        static void task2(int[] arr)
        {
            int max = Int32.MinValue;
            int index = 0;
            for (int i =  0; i< arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            int[] arrCopy = arr;
            arrCopy[index] = 1000;
            Console.WriteLine("Преобразованный массив:");
            PrintArray(arrCopy);
        }

        static void task3(int[] arr)
        {
            int max = Int32.MinValue;
            int index = 0;
            for (int i =  0; i< arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            int[] arrCopy = arr;
            for (int i = index; i < arrCopy.Length - 1; i++)
                arrCopy[i] = arr[i + 1];
            arrCopy[^1] = max;

            Console.WriteLine("Преобразованный массив:");
            PrintArray(arrCopy);
        }

        public static void ReadArray(int[] arr)
        {
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " "); 
            }
            Console.WriteLine();
        }

    }
}

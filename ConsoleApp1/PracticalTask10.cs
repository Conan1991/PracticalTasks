using System;

namespace ConsoleApp1
{
    class PracticalTask10
    {
        private static int N;
        private static int M;


        public static void PrintArray(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void ReadArray(int[,] arr)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine() ?? string.Empty);  
                }
            }
        }

        public static void CheckOdd(int[,] arr)
        {
            int[] oddInts = new int[N*M];
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        oddInts[counter++] = arr[i, j];
                    }
                }
            }

            if (oddInts[0] == 0)
            {
                Console.Write("There are no odd elements");
            }
            else
            {
                Console.Write("odd values:");
                foreach (int i in oddInts)
                {
                    if(i != 0)
                        Console.Write("\t{0}", i);
                }
            }
        }

        public static void CheckOddNumberInRows(int[,] arr)
        {
            for (int i = 0; i < N; i++)
            {
                int counter = 0;
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        counter++;
                    }
                }

                if(counter != 0)
                    Console.Write(i + "\t" + counter + Environment.NewLine);
                else
                    Console.Write(i + "\t" + "not found odd numbers" + Environment.NewLine);
            }
        }

        private static void Main(string[] args)
        {
            Console.Write("Please, enter N dimension:" + Environment.NewLine);
            N = int.Parse(Console.ReadLine() ?? string.Empty);  
            Console.Write("Please, enter M dimension:"+ Environment.NewLine);
            M = int.Parse(Console.ReadLine() ?? string.Empty);
            
            int[,] arr = new int[N,M];
            Console.Write("Please, enter array values:"+ Environment.NewLine);
            ReadArray(arr);
            Console.Write("array values:" + Environment.NewLine);
            PrintArray(arr);
            //CheckOdd(arr);
            //CheckOddNumberInRows(arr);
        }
    }
}
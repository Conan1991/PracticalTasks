using System;

namespace ConsoleApp6
{
    struct Student
    {
        public string FirstName;
        public string LastName;
        public int[] Grades;
        public double AverageGrade;

        public void PrintData()
        {
            Console.WriteLine($"Данные студента: \n FirstName: {FirstName}, LastName: {LastName} , \n " +
                              $"FirstGrade: {Grades[0]}, SecondGrade: {Grades[1]}, AverageGrade: {AverageGrade}");
        }
    }
    class PracticalTask12
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во студентов: ");
            int N = int.Parse(Console.ReadLine() ?? string.Empty);
            //Student student = new Student();
            //student.FirstName = "Alexey";
            //student.LastName = "Navalny";
            //student.Grades = new[] {4, 5};
            //student.AverageGrade = 4.5;
            //student.PrintData();
            Student[] arrStudents = new Student[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Студент {i + 1}");
                Console.Write("Имя:");
                arrStudents[i].FirstName = Console.ReadLine();
                Console.Write("Фамилия:");
                arrStudents[i].LastName = Console.ReadLine();

                Console.Write("Оценки:");
                arrStudents[i].Grades = new[]
                {
                    int.Parse(Console.ReadLine() ?? string.Empty),
                    int.Parse(Console.ReadLine() ?? string.Empty)
                };

                if (arrStudents[i].Grades[0] < 1 || arrStudents[i].Grades[0] > 5 ||
                    arrStudents[i].Grades[1] < 1 || arrStudents[i].Grades[1] > 5)
                {
                    Console.WriteLine("Incorrect Grade");
                    return;
                }

                arrStudents[i].AverageGrade = calcAverageGrade(arrStudents[i].Grades);
            }

            //Console.WriteLine("Исходные данные:");
            //PrintStudents(arrStudents);
            //task1(arrStudents);
            //task2(arrStudents);
            task3(arrStudents);
        }

        static double calcAverageGrade(int[] graInts)
        {
            int sum = 0;
            double average = 0;
            foreach (int graInt in graInts)
            {
                sum += graInt;
            }

            average = sum / (double) graInts.Length;
            return average;
        }

        static void PrintStudents(Student[] arrStudents)
        {
            Console.WriteLine("         №                   Имя       Фамилия        Оценка1        Оценка2");
            for (int i = 0; i < arrStudents.Length; i++)
            {
                Console.WriteLine($"{i+1,10}{arrStudents[i].FirstName, 20}{arrStudents[i].LastName, 10}" +
                                  $"{arrStudents[i].Grades[0], 15}{arrStudents[i].Grades[1],15}");
            }
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"{student.FirstName, 20}{student.LastName, 10}" +
                              $"{student.Grades[0], 15}{student.Grades[1],15}");
        }

        static void task1(Student[] arrStudents)
        {
            Console.WriteLine("Информация о студентах, сдавших сессию на отлично:");
            Console.WriteLine("                   Имя       Фамилия        Оценка1        Оценка2");
            for (int i = 0; i < arrStudents.Length; i++)
            {
                if(IsExcellentMarks(arrStudents[i].Grades))
                    PrintStudent(arrStudents[i]);
            }
        }

        static bool IsExcellentMarks(int[] graInts)
        {
            bool res = true;
            foreach (int graInt in graInts)
            {
                if (graInt != 5)
                    return false;
            }

            return res;
        }

        static bool IsGoodMark(int[] graInts)
        {
            bool res = false;
            foreach (int graInt in graInts)
            {
                if (graInt == 4)
                    return true;
            }

            return res;
        }

        static void task2(Student[] arrStudents)
        {
            int counter = 0;
            for (int i = 0; i < arrStudents.Length; i++)
            {
                if (IsGoodMark(arrStudents[i].Grades))
                    counter++;
            }
            if(counter == 0)
                Console.WriteLine("Нет студентов, имеющих оценку 4.");
            else Console.WriteLine("Количество студентов, имеющих оценку 4 = {0}",counter);
        }

        static void task3(Student[] arrStudents)
        {
            Console.WriteLine("Студенты в порядке возрастания средней оценки:");
            choiceSort(arrStudents);
        }

        public static void choiceSort(Student[] arrayToSort) {
            int indexMin;
            for (int i = 0; i < arrayToSort.Length - 1; i++) {
                indexMin = i;
                for (int j = i + 1; j < arrayToSort.Length; j++) {
                    if (arrayToSort[indexMin].AverageGrade > arrayToSort[j].AverageGrade) {
                        indexMin = j;
                    }
                }
                Student temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[indexMin];
                arrayToSort[indexMin] = temp;
            }
            PrintStudents(arrayToSort);
        }
    }
}

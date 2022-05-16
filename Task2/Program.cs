using Sorting;
using System;
using System.Collections.Generic;

namespace Task2
{

    class Program
    {
        static readonly string CHOOSE_SORT_TEXT = "Сортировка: \n" +
            "1) По сумме \n" +
            "2) По максимальному элементу \n" +
            "3) По минимальному значению";

        static readonly string SORT_TYPE_TEXT = "Порядок: \n" +
            "1) По возрастанию \n" +
            "2) По убыванию ";

        public static int[][] arr = {
                            new int[4]{2,9,4,125},
                            new int[4]{4,3,16,25},
                            new int[4]{8,1,64,5}
                           };

        static void Main()
        {
            print(arr);
            while (true)
            {
                sort();
                print(arr);
            }
        }

        private static void sort()
        {
            var dict = new Dictionary<int, AbstractSortingStrategy>{
                { 1, new SumSortingStrategy()},
                { 2, new MaxSortingStrategy()},
                { 3, new MinSortingStrategy()}
            };

            Console.WriteLine(CHOOSE_SORT_TEXT);
            int sortType = int.Parse(Console.ReadLine());
            SortingDelegate myDelegate = dict[sortType].Sort;
            Context context = new Context(myDelegate);

            Console.WriteLine(SORT_TYPE_TEXT);
            int reverse = int.Parse(Console.ReadLine());

            context.Sort(ref arr, reverse != 1);
        }

        public static void print(int[][] array)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

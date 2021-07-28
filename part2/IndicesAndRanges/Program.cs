using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {

            Task2();


        }

        public static void Task1()
        {
            // Индексы и диапазоны
            int[] myArray = { 1, 23, 4, 5, 6, 43, 2, 1, 3 };

            // последний элемент массива
            Console.WriteLine(myArray[8]);
            Console.WriteLine(myArray[myArray.Length - 1]);
            // синтаксический сахар в версии C#8
            Console.WriteLine(myArray[^1]);
           


        }
        public static void Task2()
        {
            // диапазоны
            int[] myArray = { 1, 23, 4, 5, 6, 43, 2, 1, 3 };





        }
    }
}

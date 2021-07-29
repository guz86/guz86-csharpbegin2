using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {

            Task2();


        }
        // Индексы и диапазоны

        public static void Task1()
        {
            // Индексы
            int[] myArray = { 1, 23, 4, 5, 6, 43, 2, 1, 3 };

            // последний элемент массива
            Console.WriteLine(myArray[8]);
            Console.WriteLine(myArray[myArray.Length - 1]);
            // синтаксический сахар в версии C#8
            Console.WriteLine(myArray[^1]);

            // 1   второй элемент с конца
            Console.WriteLine(myArray[^2]);



        }
        public static void Task2()
        {
            // диапазоны
            int[] myArray = { 1, 23, 4, 5, 6, 43, 2, 1, 3 };

            // 23, 4, 5
            int[] myArrayTwo = myArray[1..4];

            // 1, 23, 4, 5
            int[] myArrayThree = myArray[..4];

            // 43, 2, 1, 3
            int[] myArrayFour = myArray[5..];


            // 43, 2, 1
            int[] myArrayFive = myArray[^4..^1];
            // диапазон
            Range MyRange = ^4..^1; 
            int[] myArraySix = myArray[MyRange];

        }
    }
}

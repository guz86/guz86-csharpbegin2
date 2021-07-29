using System;

namespace multidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayRandom();
        }
        public static void Lesson()
        {
            // Многомерные массивы
                               //0  1  2
            int[,] myArray = { { 2, 3, 4 },
                               { 1, 9, 2 },
                               { 5, 2, 4 } };

            Console.WriteLine(myArray[0,2]);
            Console.WriteLine(myArray[1, 1]);
            Console.WriteLine(myArray.Length);
            // нулевое измерение - строки
            Console.WriteLine(myArray.GetLength(0));
            // первое измерение  - столбцы
            Console.WriteLine(myArray.GetLength(1));
            // перебор
            Console.WriteLine();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i,j]+" ");
                }
                Console.WriteLine();
            }

        }

        public static void ArrayRandom()
        {
            int[,] myArrayRandom = new int[10, 6];
            Random rand = new Random();
            for (int i = 0; i < myArrayRandom.GetLength(0); i++)
            {
                for (int j = 0; j < myArrayRandom.GetLength(1); j++)
                {
                    myArrayRandom[i, j] = rand.Next(1, 9);
                    Console.Write(myArrayRandom[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

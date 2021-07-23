using System;
using System.Linq;

namespace sumOfEvenNumbersInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти сумму четных чисел в массиве

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenSum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] % 2 == 0)
                {
                    evenSum += myArray[i];
                }

            }
            Console.WriteLine(evenSum);

            // реализация задачи // using System.Linq;
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());


        }
    }
}

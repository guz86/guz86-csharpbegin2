using System;

namespace massiveReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // вывести массив в обратном порядке

            int[] array = { 2, 1, 2, 3, 4, 5 };

            Console.Write("Массив 1: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }

            int[] arrayReverse = new int[array.Length];

            for (int i = 0, j = array.Length-1; i < array.Length; i++, j--)
            {
                arrayReverse[j] = array[i];
            }

            Console.Write("\nМассив 2: ");

            for (int i = 0; i < arrayReverse.Length; i++)
            {
                Console.Write(arrayReverse[i] + " ");
            }

        }
    }
}

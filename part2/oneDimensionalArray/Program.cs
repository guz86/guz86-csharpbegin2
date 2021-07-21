using System;

namespace oneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int[] arrayTwo = new int[3];
            string[] arrayThree = new string[3] { "dsf", "fsdf", "asdasd"};

            int sum = 0;

            Random rand = new Random();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                arrayTwo[i] = rand.Next(0, 100);
                Console.WriteLine(arrayTwo[i]);
                sum += arrayTwo[i];
            }

            Console.WriteLine(sum);
            



        }
    }
}

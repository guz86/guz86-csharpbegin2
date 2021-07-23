using System;
using System.Linq;

namespace findTheSmallestNumberInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, -5, -6, -999 };
            // int smallValue = int.MaxValue;
            int minValue = myArray[0];
            // for (int i = 0; i < myArray.Length; i++)
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                
            }
            Console.WriteLine(minValue);

            // типичное решение для этой задачи
            // using System.Linq;
            // int result = myArray.Min();
            // int result = myArray.Max();

            Console.WriteLine(myArray.Min());

        
        }
    }
}
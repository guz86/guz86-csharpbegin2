using System;

namespace findTheSmallestNumberInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, -5, -6, -999 };
            // int smallValue = int.MaxValue;
            int smallValue = myArray[0];
            // for (int i = 0; i < myArray.Length; i++)
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < smallValue)
                {
                    smallValue = myArray[i];
                }
                
            }
            Console.WriteLine(smallValue);
        }
    }
}

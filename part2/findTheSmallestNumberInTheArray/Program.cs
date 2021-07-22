using System;

namespace findTheSmallestNumberInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, -5, -6, -999 };
            int smallValue = int.MaxValue;
            for (int i = 0; i < myArray.Length; i++)
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

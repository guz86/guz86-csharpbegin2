using System;

namespace problemSolvingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти два наибольших элемента массива

            int[] myArray = { 23, 4, 78, 81,2,3,4,5,66,777,5 };
            int maxElementOne= myArray[0];
            int maxElementTwo = myArray[0];
            int previous = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxElementOne)
                {
                    previous = maxElementOne;
                    maxElementOne = myArray[i];
                }

                if (myArray[i] > maxElementTwo)
                {
                    maxElementTwo = myArray[i];
                }

                if (maxElementOne == maxElementTwo)
                {
                    maxElementTwo = previous;
                }
            }

            Console.WriteLine(maxElementOne + " "+maxElementTwo);


        }
    }
}

using System;

namespace problemSolvingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        public static void Task1()
        {
            // найти два наибольших элемента массива

            int[] myArray = { 283383, 33334, 78, 81, 2, 3, 4, 5, 66, 777, 885 };
            int maxElementOne = int.MinValue;
            int maxElementTwo = int.MinValue;
            int previous = int.MinValue;
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

            Console.WriteLine(maxElementOne + " " + maxElementTwo);


        }
        public static void Task2()
        {
            // найти два наибольших элемента массива





        }





    }
}

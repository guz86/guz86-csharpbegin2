﻿using System;
using System.Linq;

namespace problemSolvingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5();
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
            // заполнить массив по возрастанию от 1 до 100

            // int[] myArray = Enumerable.Range(1, 100).ToArray();

            int[] myArray = new int [100];

            for (int i = 0; i < 100; i++)
            {
                myArray[i] = i+1;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }

        public static void Task3()
        {
            // проверить нет ли в массиве одинаковых чисел
            bool equalNumber = false;
            int[] myArray = {  1,2,3,4,5,6,24,123,11,22};
            
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        equalNumber = true;
                        break;
                    }

                }
                if (equalNumber)
                {
                    break;
                }
            }
            Console.WriteLine(equalNumber);
        }

        public static void Task4()
        {
            // переставить элементы массива в обратном порядке, используя дополнительный массив

            int[] myArray = { 9, 2, 3, 4, 5, 8 };
            int[] myArrayReverse = new int [myArray.Length];

            for (int i = myArray.Length-1, j = 0; i >= 0 ; i--,j++)
            {
                myArrayReverse[j] = myArray[i];
            }
            // вывод
            for (int i = 0; i < myArrayReverse.Length; i++)
            {
                Console.Write(myArrayReverse[i]+" ");
            }

        }

        public static void Task5()
        {
            // переставить элементы массива в обратном порядке, используя дополнительный массив версия с урока

            int[] myArray = { 9, 2, 3, 4, 5, 8 };
            int[] myArrayReverse = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArrayReverse[myArray.Length - 1 - i] = myArray[i];
            }
            // вывод
            for (int i = 0; i < myArrayReverse.Length; i++)
            {
                Console.Write(myArrayReverse[i] + " ");
            }

        }
    }
}

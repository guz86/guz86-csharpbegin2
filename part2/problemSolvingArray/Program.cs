﻿using System;
using System.Linq;

namespace problemSolvingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            extensionArray();
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

            int[] myArray = new int[100];

            for (int i = 0; i < 100; i++)
            {
                myArray[i] = i + 1;
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
            int[] myArray = { 1, 2, 3, 4, 5, 6, 24, 123, 11, 22 };

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
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
            int[] myArrayReverse = new int[myArray.Length];

            for (int i = myArray.Length - 1, j = 0; i >= 0; i--, j++)
            {
                myArrayReverse[j] = myArray[i];
            }
            // вывод
            for (int i = 0; i < myArrayReverse.Length; i++)
            {
                Console.Write(myArrayReverse[i] + " ");
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


        public static void Task6()
        {
            // переставить элементы массива в обратном порядке, НЕ используя дополнительный массив

            int[] myArray = { 9, 2, 3, 4, 5, 8, 10, 44, 55, 6, 7, 8 };
            for (int i = 0; i < myArray.Length / 2; i++)
            {
                int tempContainer = myArray[i];
                myArray[i] = myArray[myArray.Length - 1 - i];
                myArray[myArray.Length - 1 - i] = tempContainer;
            }
            // вывод
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }




        //         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //        You can return the answer in any order.



        //        Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //        Output: [0,1]
        //Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        public static void Solution()
        {

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    Console.WriteLine("[" + nums[i] + ", " + nums[i + 1] + "]");
                }
            }




        }

        // задачи на двумерные массивы

        // посчитать сумму чисел в двумерном массиве
        public static void SumOfNumbers()
        {
            int[,] myArray = { { 1, 2, 3 }, { 3, 2, 1 }, { 1, 1, 2 } };
            int sumElement = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sumElement += myArray[i, j];
                }
            }
            Console.WriteLine(sumElement);


            // чудной вариант с ютуба



            int[,] myArrayTwo = { { 1, 2, 3 }, { 3, 2, 1 }, { 1, 1, 2 } };
            int sumElementTwo = 0;
            int colums = myArrayTwo.GetUpperBound(0) + 1;
            int rows = myArrayTwo.Length / colums;
            for (int i = 0; i < colums; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sumElementTwo += myArrayTwo[i, j];
                }
            }
            Console.WriteLine(sumElementTwo);
        }

        // заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран

        public static void tenTenRandom()
        {
            int[,] myArray = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(1, 10);
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }



        }

        public static void TwoOneArray()
        {
            int[,] myArray = { { 1, 2, 3 }, { 3, 2, 1 }, { 1, 1, 2 } };
            int[] myArrayTwo = new int[myArray.Length];
            int k = 0;
            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                for (int i = 0; i < myArray.GetLength(1); i++)
                {
                    myArrayTwo[k]= myArray[j, i];
                    k++;
                }
            }

        }

        // заполнить массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве

        public static void arrayOddCount()
        {
            int[,] myArray = new int[10, 10];
            Random rand = new Random();
            int countOdd = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(1,100);
                    if (myArray[i,j] % 2 == 0)
                    {
                        countOdd++;
                    }
                }
            }
            Console.WriteLine(countOdd);
        }

        // одномерный массив скопировать в двумерный 4 на 4

        public static void oneArrayTwo()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 15 };
            int[,] myArrayTwo = new int[4,4];
            int j = 0, k = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]+ " ");
                myArrayTwo[j, k] = myArray[i];
                k++;

                Console.Write(myArrayTwo[j, k] + " ");

                if (k % 4 == 0)
                {
                    j++;
                    k = 0;
                }
            }
            Console.WriteLine();


        }

        public static void oneArrayTwoVer2()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 15 };
            int[,] myArrayTwo = new int[4, 4];
            int k = 0;
            for (int i = 0; i < myArrayTwo.GetLength(0); i++)
            {
                for (int j = 0; j < myArrayTwo.GetLength(1); j++)
                {
                    myArrayTwo[i, j] = myArray[k];
                    k++;
                    Console.Write(myArrayTwo[i, j] + " ");
                }
                Console.WriteLine();
            }

            
        }
        
        // расширить массив +1 элемент и добавить к нему значение 99
        public static void extensionArray()
        {
            // int[] bag = new int[1];
            int[] bag = { 1,23,4,5};
            int[] tempBag = new int[bag.Length + 1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
            }
            // tempBag[tempBag.Length - 1] = 99; 
            tempBag[^1] = 99;

            bag = tempBag;
            Console.WriteLine(bag[^1]);
            Console.WriteLine(bag.Length);
        }
    }
}

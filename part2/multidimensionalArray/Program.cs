using System;

namespace multidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensionalArray();
        }
        public static void Lesson()
        {
            // Многомерные массивы
            //0  1  2
            int[,] myArray = { { 2, 3, 4 },
                               { 1, 9, 2 },
                               { 5, 2, 4 } };

            Console.WriteLine(myArray[0, 2]);
            Console.WriteLine(myArray[1, 1]);
            Console.WriteLine(myArray.Length);
            // нулевое измерение - строки
            Console.WriteLine(myArray.GetLength(0));
            // первое измерение  - столбцы
            Console.WriteLine(myArray.GetLength(1));
            // перебор
            Console.WriteLine();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void ArrayRandom()
        {
            int[,] myArrayRandom = new int[10, 6];
            Random rand = new Random();
            for (int i = 0; i < myArrayRandom.GetLength(0); i++)
            {
                for (int j = 0; j < myArrayRandom.GetLength(1); j++)
                {
                    myArrayRandom[i, j] = rand.Next(1, 9);
                    Console.Write(myArrayRandom[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void ArrayPractic()
        {
            // контроль для библиотеки

            string[,] myLibrory = { { "Достаевский", "Глуховский", "Быков" },
                                     { "Аллен Кар", "Стивен Кинг", "Брем Стокер" },
                                     { "Донцова", "Усанов", "Прокопенко" } };
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Библиотека\n");
                Console.WriteLine("1 - Получить книгу по индексу, 2 - Найти книгу по автору, 3 - Вывод книг, 4 - Выход.");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Введите номер полки: ");
                        int rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер: ");
                        int cols = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("\n" + myLibrory[rows, cols]);
                        break;
                    case 2:
                        Console.Write("Введите автора: ");
                        string author = Console.ReadLine();
                        bool authorIsFind = false;
                        for (int i = 0; i < myLibrory.GetLength(0); i++)
                        {
                            for (int j = 0; j < myLibrory.GetLength(1); j++)
                            {
                                if (author.ToLower() == myLibrory[i, j].ToLower())
                                {
                                    Console.WriteLine("Книга автора: " + myLibrory[i, j] + " находится на полке " + (i + 1) + ", место " + (j + 1));
                                    authorIsFind = true;
                                    break;
                                }
                            }
                        }
                        if (authorIsFind == false)
                        {

                            Console.WriteLine("Такого автора нет.");
                        }

                        break;
                    case 3:
                        Console.WriteLine("\nВесь список авторов: \n");
                        for (int i = 0; i < myLibrory.GetLength(0); i++)
                        {
                            for (int j = 0; j < myLibrory.GetLength(1); j++)
                            {
                                Console.Write(myLibrory[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 4:
                        isOpen = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }




        }

        public static void JaggedArray()
        {
            // зубчатые ступенчатые массивы, массив массивов  jagged array строки могут содержать разное количество элементов

            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[1];

            myArray[0][3] = 3;

            // заполнение случайными числами

            Random rand = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(i + " -> " + "\t");
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(100);
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // инициализация зубчатого массива

            int[][] myArrayTest =
            {
                new int[2] { 1, 2 },
                new int[3] { 8, 9, 10 }
            };


        }

        // трехмерные массивы
        public static void ThreeDimensionalArray()
        {
            // int[,,] myArray = new int [5, 2, 3];
            int[,,] myArray =
            {
                {
                    {1,2,3 },
                    {4,2,1 },
                    {2,2,2 }
                },
                {
                    {5,6,3 },
                    {1,2,3 },
                    {1,6,3 }
                },
                {
                    {1,7,3 },
                    {1,2,8 },
                    {8,2,3 }
                }
            };

            // заполним случайными числами
            Random rand = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k   = 0; k < myArray.GetLength(2); k++)
                    {
                        // Console.Write(myArray[i,j,k]+" ");
                        myArray[i, j, k] = rand.Next(10);
                    }
                }
            }
            // вывод 
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page № "+(i+1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                         Console.Write(myArray[i,j,k]+" ");
                       
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // зубчатый трехмерный массив

            int[][][] myArrayTwo = new int [rand.Next(2,5)][][];

            for (int i = 0; i < myArrayTwo.Length; i++)
            {
                // генерируем количество элементов и выделяем память
                myArrayTwo[i] = new int[rand.Next(2,6)][];

                for (int j = 0; j < myArrayTwo[i].Length; j++)
                {
                    // генерируем количество элементов и выделяем память
                    myArrayTwo[i][j] = new int[rand.Next(2, 15)];

                    for (int k = 0; k < myArrayTwo[i][j].Length; k++)
                    {
                        myArrayTwo[i][j][k] = rand.Next(100);
                    }
                }
            }

            // вывод
            for (int i = 0; i < myArrayTwo.Length; i++)
            {

                for (int j = 0; j < myArrayTwo[i].Length; j++)
                {

                    for (int k = 0; k < myArrayTwo[i][j].Length; k++)
                    {
                         Console.Write(myArrayTwo[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

        }

    }
}

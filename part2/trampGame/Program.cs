using System;
using System.Threading;

namespace trampGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTwo();
        }

        public static void GameOne()
        {
            // отключаем курсор
            Console.CursorVisible = false;
            char[,] map =
            {
                {' ', '-', '-', '-', '-', '-', '-', '-','-', '-', '-','-', '-', '-', '-', ' ', },

                {'|', '*', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', '*', '|', },

                {'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', '|', },

                {'|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ','*', ' ', ' ', ' ', '|', },

                {'|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ','*', ' ', ' ', ' ', '|', },

                {'|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', ' ', ' ', '|', },

                {'|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ','*', ' ', ' ', ' ', '|', },

                {'|', ' ', '|', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', ' ', ' ', ' ', '|', },

                {'|', ' ', '|', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', '*', ' ', ' ', ' ', '|', },

                {'|', '*', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', '|', },
                {' ', '-', '-', '-', '-', '-', '-', '-','-', '-', '-','-', '-', '-', '-', ' ', }
            };
            int userX = 6, userY = 6;

            char[] bag = new char[0];

            while (true)
            {

                Console.SetCursorPosition(0, 11);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                // информация о нажатой клавише
                ConsoleKeyInfo charKey = Console.ReadKey();



                switch (charKey.Key)
                {

                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '|')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '-')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '|')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '-')
                        {
                            userX++;
                        }
                        break;
                    default:
                        break;
                }

                if (map[userX, userY] == '*')
                {
                    map[userX, userY] = ' ';
                    // добавление в сумку
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = '*';
                    bag = tempBag;

                }



                Console.Clear();
            }
        }

        public static void GameTwo()
        {
            Console.CursorVisible = false;

            char[,] map = {
                { '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.'},
                { '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            };

            Random rand = new Random();
            int xUser, yUser;

            char[] bag = new char[0];

            // map.GetLength(0) 16  высота
            // map.GetLength(1) 43  ширина

            yUser = rand.Next(1, map.GetLength(1) - 1);
            xUser = rand.Next(1, map.GetLength(0) - 1);

            int stepCount = 0;

            bool health = true;

            //  сокровища

            // размещаем по карте камни
            Console.SetCursorPosition(0, 0);
            for (int i = 1; i < map.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < map.GetLength(1) - 1; j++)
                {
                    int gem = rand.Next(0, 30);
                    if (gem > 28)
                    {
                        map[i, j] = '*';
                    }
                    
                }
                Console.WriteLine();
            }

            while (health)
            {
                Console.SetCursorPosition(0, map.GetLength(0) + 2);
                Console.Write("Сделано шагов: "+ stepCount);
                Console.SetCursorPosition(0, map.GetLength(0) + 3);
                Console.Write("Рюкзак: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.WriteLine("\n\nСобери ВСЕ сокровища и сделай меньше 100 шагов!");

                Console.WriteLine("\n\n Управление с помощью стелок Вверх Вниз Влево Вправо!");

                // карта
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                // юзер

                // Console.WriteLine(yUser + " " + xUser);

                Console.SetCursorPosition(yUser, xUser);
                Console.Write('@');

                ConsoleKeyInfo charKey = Console.ReadKey();

                stepCount++;

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[xUser - 1, yUser] != '.')
                        {
                            xUser--;

                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[xUser + 1, yUser] != '.')
                        {
                            xUser++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[xUser, yUser - 1] != '.')
                        {
                            yUser--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[xUser, yUser + 1] != '.')
                        {
                            yUser++;
                        }
                        break;
                    default:
                        break;
                }

                if (map[xUser, yUser] == '*')
                {
                    map[xUser, yUser] = ' ';
                    // добавление в сумку
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = '*';
                    bag = tempBag;
                }

                Console.Clear();

                if (stepCount >=5)
                {

                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Вы устали! Слишком много шагов!");

                    Console.ReadKey();
                    Thread.Sleep(3000);

                    health = false;
                }


            }




        }



    }
}

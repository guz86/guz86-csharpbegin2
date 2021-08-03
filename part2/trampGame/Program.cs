using System;

namespace trampGame
{
    class Program
    {
        static void Main(string[] args)
        {
            gameOne();
        }

        public static void gameOne()
        {
            // отключаем курсор
            Console.CursorVisible = false;
            char[,] map =
            {
                {' ', '-', '-', '-', '-', '-', '-', '-','-', '-', '-','-', '-', '-', '-', ' ', },

                {'|', '*', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', '*', '|', },

                {'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', '|', },

                {'|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ','*', ' ', ' ', ' ', '|', },

                {'|', ' ', '|', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', ' ', ' ', ' ', '|', },

                {'|', ' ', '|', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', '*', ' ', ' ', ' ', '|', },

                {'|', '*', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ', ' ',' ', ' ',' ', ' ', '|', },
                {' ', '-', '-', '-', '-', '-', '-', '-','-', '-', '-','-', '-', '-', '-', ' ', },
            };
            int userX = 6, userY = 6;
            
            char[] bag = new char[0]; 

            while (true)
            {

                Console.SetCursorPosition(0, 9);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i]+ " ");
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i,j]);
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
                        if (map[userX - 1,userY] != '-')
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

                if (map[userX,userY] == '*')
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

    }
}

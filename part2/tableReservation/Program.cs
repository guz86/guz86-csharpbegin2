using System;

namespace tableReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            // свободные места для бронирования
            int[] tables = { 2, 4, 6, 5, 2, 3, 4, 2 };
            bool openCafe = true;



            while (openCafe)
            {
                Console.WriteLine("1 - выберите столик, 2 - выход: ");

                Console.SetCursorPosition(0, 10);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine("Мест за столом " + (i + 1) + " : " + tables[i]);
                }


                Console.SetCursorPosition(0, 1);
                int chooseUser = 0;

                try
                {
                    chooseUser = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не верный выбор");


                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }


                

                switch (chooseUser)
                {
                    case 1:
                        int userTable, UserPlace;

                        Console.Write("Какой стол вы хотите выбрать: ");
                        userTable = Convert.ToInt32(Console.ReadLine())-1;

                        if ( userTable >= tables.Length || userTable < 0)
                        {
                            Console.WriteLine("Нет такого стола");
                            break;
                        }

                        Console.Write("Сколько мест нужно: ");
                        UserPlace = Convert.ToInt32(Console.ReadLine());
                     

                        if (tables[userTable] < UserPlace || UserPlace < 0)
                        {
                            Console.WriteLine("За этим столом нет "+ UserPlace + " мест");
                            break;
                        }

                        tables[userTable] -= UserPlace;

                        break;


                    case 2:
                        openCafe = false;
                        break;
                    default:
                        Console.WriteLine("Повторите попытку");
                        break;

                }
                Console.ReadKey();
                Console.Clear();







            }
        }
    }
}

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
                Console.Write("1 - выберите столик, 2 - выход: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        break;
                    case 2:
                        openCafe = false;
                        break;

                }

            }
        }
    }
}

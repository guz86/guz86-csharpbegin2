using System;
using System.Linq;

namespace massiveDz
{
    class Program
    {
        static void Main(string[] args)
        {



            // объявление

            int[] myArray; // объявляем массив
            myArray = new int[5]; // выделяем под него память
                                  // аналогично
            int[] myArrayTwo = new int[5];
            // элементы массива
            int[] myArrayThree = new int[5] { 1, 2, 3, 3, 3 };
            // аналогично без явного укозания количества элементов
            int[] myArrayFour = new int[] { 1, 2, 2, 3, 4 };
            // аналогично можно упустить тип элементов
            int[] myArrayFive = new[] { 1, 2, 3, 4, 4, 4 };
            // аналогично еще более упрощаем
            int[] myArraySix = { 1, 2, 3, 4, 5, 2, 2, 2 };

            // инициализация массива определенными значениями
            // using System.Linq;
            int[] myArraySeven = Enumerable.Repeat(4, 10).ToArray();

            int[] myArrayEight = Enumerable.Range(0, 99).ToArray();



            //  заполнить массив с клавиатуры



            //while (true)
            //{
            //Console.WriteLine("\nДобавить значение в массив - 1");
            int[] myArrayKeyboard;


            //switch (Convert.ToInt32(Console.ReadLine()))
            //{
            //        case 1:

            Console.WriteLine("Сколько элементов будет в массиве:");

            //ввод пользователя и проверка
            
            if (int.TryParse(Console.ReadLine(), out int result))
            {
            }
            else
            {
                Console.WriteLine("Введите число!");
            }

            myArrayKeyboard = new int[Convert.ToInt32(result)];

            // myArrayKeyboard = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < myArrayKeyboard.Length; i++)
            {
                Console.Write($"Введите значение элемента массива {i}: ");

                //ввод пользователя и проверка
                if (int.TryParse(Console.ReadLine(), out int resultTwo))
                {
                }
                else
                {
                    Console.WriteLine("Введите число!");
                }

                myArrayKeyboard[i] = Convert.ToInt32(resultTwo);
            }
            Console.WriteLine();
            Console.Write("Мы получили массив: ");
            for (int i = 0; i < myArrayKeyboard.Length; i++)
            {
                Console.Write(myArrayKeyboard[i] + " ");
            }
            Console.ReadKey();

            //            break;

            //default:

            //break;
            // }

            //}







        }
    }
}

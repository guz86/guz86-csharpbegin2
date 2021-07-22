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

            int[] myArrayKeyboard;


            while (true)
            {
                Console.WriteLine("Добавить значение в массив 1 или любую клавишу");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        Console.WriteLine("Сколько элементов будет в массиве:");
                        myArrayKeyboard = new int[Convert.ToInt32(Console.ReadLine())];
                        for (int i = 0; i < myArrayKeyboard.Length; i++)
                        {
                            Console.WriteLine("Введите значение:");
                            myArrayKeyboard[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        for (int i = 0; i < myArrayKeyboard.Length; i++)
                        {
                            Console.Write(myArrayKeyboard[i]+" ");
                        }
                        break;

                    default:

                        break;
                }



            }


        }
    }
}

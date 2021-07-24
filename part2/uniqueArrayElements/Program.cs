using System;
//using System.Linq;

namespace uniqueArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти только уникальные элементы массива и поместить их в другой массив

            int[] myArray = { 1, 3, 3, 2, 1, 3, 2, 1 };


            // отсортировать массив от меньшего к большему
            //  Array.Sort(myArray);

            // реализация сортировки пузырьком
            // легкий алгоритм
            // изначальный массив
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine("\n\n");

            // сортировка пузырьком
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int changeElement = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = changeElement;
                    }
                }

               
            }

            // сортированный массив
            for (int i = 0; i < myArray.Length; i++)
            {
            Console.Write(myArray[i] + " ");
            }


            Console.WriteLine("\n\n");

            int m = 0;

            for (int i = 0; i < myArray.Length; i++)
            {

                while (i < myArray.Length - 1 && myArray[i] == myArray[i + 1])
                {
                    i++;
                }
                m++;

            }
            Console.WriteLine("m = " + m);





            // реализация через Linq

            //  int[] myArrayUniq = myArray.Distinct().ToArray();




            //  for (int i = 0; i < myArrayUniq.Length; i++)
            //   {
            //      Console.Write(myArrayUniq[i]+ " ");
            //  }

        }
    }
}

using System;
using System.Linq;

namespace uniqueArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти только уникальные элементы массива и поместить их в другой массив

            int[] myArray = { 1, 3, 3, 2, 1, 322,3,1,23,56,6,5,6,7,8,9,0,3,4,5,6,7,8,33, 2, 1 };


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


            // реализация через Linq сортировки

            //int[] result = myArray.OrderBy(i => i).ToArray();
            // обратный порядок
            //int[] result = myArray.OrderByDescending(i => i).ToArray();

            // Array навести и нажать f12 чтобы посмотреть методы класса
            // пример сортировки через методы класса Array.Sort(myArray);

            Console.WriteLine("\n\n");


            // удаляем дубликаты
           
            int countElement = 0;

            Console.WriteLine("Ищем дубликаты: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    //Console.WriteLine(myArray[i]);
                    countElement += 1;
                }
            }
            // Console.WriteLine(countElement);
            int[] myArrayThree = new int[countElement];
            for (int i = 0, k = -1; i < myArray.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    //Console.WriteLine(myArray[i]);
                    k++;
                    myArrayThree[k] = myArray[i];
                }
            }

            // new clear
            Console.Write(" new clear array: ");

            for (int i = 0; i < myArrayThree.Length; i++)
            {
                Console.Write(myArrayThree[i] + " ");
            }


            Console.WriteLine("\n-----------------");



            // Traditional Approach
            int[] myArrayTwo = { 1, 3, 3, 2, 1, 3, 2, 1 };
             
                int n = myArrayTwo.Length;
                
                Console.WriteLine("Unique array elements: ");

                for (int i = 0; i < n; i++)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (myArrayTwo[i] == myArrayTwo[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        Console.WriteLine(myArrayTwo[i]);
                    }
                }


            // add value

            int[] arr = { 1, 2, 3,3,1 };
            // create a new array
            int x = 6;
            int[] arrnew = new int[arr.Length + 1];
            // old
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            // add
            for (int i = 0; i < arrnew.Length; i++)
            {
                if (i < arrnew.Length - 1)
                    arrnew[i] = arr[i];
                else if (i == arr.Length)
                    arrnew[i] = x;
                //else
                 //   arrnew[i] = arr[i - 1];
            }

            // new
            Console.WriteLine("");
            
            for (int i = 0; i < arrnew.Length; i++)
            {
                Console.Write(arrnew[i] + " ");
            }















            // реализация через Linq

            //  int[] myArrayUniq = myArray.Distinct().ToArray();




            //  for (int i = 0; i < myArrayUniq.Length; i++)
            //   {
            //      Console.Write(myArrayUniq[i]+ " ");
            //  }

            // найти элемент больше 5 через метод класса array

            // int res = Array.Find(myArray, i => i >5);

            // пробежится по массиву и найдет первый элемент который удовлетворяет условию

        }
    }
}

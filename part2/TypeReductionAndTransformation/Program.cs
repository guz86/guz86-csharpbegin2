using System;

namespace TypeReductionAndTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // приведение и преобразование типов

            string m = "1";
            int n = m; // не удается не явно преобразовать

            int j = 5;
            double k = j; // неявное приведение типов работает только в одну сторону
            int p = k;

            // неявное приведение типов
            byte b = 44;  // byte.MaxValue 255
            int i = b; // int.MaxValue значительно больше

            int t = 1;
            int d = 3555;

            byte r = t;
            byte a = d;
            // в обоих случая компилятор не позволяет неясно преобразовать и в этом случае используется Явное приведение
            
            // явное приведение типов
            byte q = (byte)t;
            byte z = (byte)d; // под отвественность программиста, значения пойдут по кругу и попадут в значение до 255

            // когда не работает явное приведение типов
            string hh = "12345";
            int tt = hh;
            int ttt = (int)hh;
            // используется преобразование типов
            int tttt = Convert.ToInt32(hh);
            int ttttt = int.Parse(hh);

            string jj = "true";
            bool ll = Convert.ToBoolean(jj);


            // неявное преобразование
            int yy = 123;
            string uu = "ttatata "+ yy; // преобразует целое число в строку и объединяет


            //лучше использовать проверка на корректность
            string hhh = "123";
            if (int.TryParse(hhh, out int result))
            {
                Console.WriteLine(result);
            }






        }
    }
}

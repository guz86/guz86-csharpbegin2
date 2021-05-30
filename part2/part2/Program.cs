using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else

            /*
            
            int age;
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("Добро пожаловать в клуб!");
                Console.WriteLine("Что вам налить?");
            }
            else
            {
                Console.WriteLine("Извините, мы вас не можем обслужить! Вы еще юны. ");
                Console.WriteLine("Приходите к нам через "+ (18 - age) + " лет! Всего хорошего!");
            }

            */

            // Другой пример

            /*

            string day;

            Console.WriteLine("Введите день недели!");
            day = Console.ReadLine();
            if (day== "Понедельник")
            {
            Console.WriteLine("Изучаем курсы!");
            }
            else if (day == "Вторник")
            {
            Console.WriteLine("Проходим домашнее задание!");
            }

            */

            // Логическое И и ИлИ

            // && логическое И (правила схожи с умножением, если хотя бы одно условие не верно то ложь "Если все условия верны то будет истина")
            // X   Y   X&&Y
            // 1 | 1 | 1
            // 1 | 0 | 0
            // 0 | 1 | 0
            // 0 | 0 | 0


            // || логическое ИЛИ (правила схожи со сложением, но 1+1=1 "Если хотя бы одно условие верно то истина")
            // X   Y   X||Y
            // 1 | 1 | 1
            // 1 | 0 | 1
            // 0 | 1 | 1
            // 0 | 0 | 0

            // Если у игрока больше 500 денег или уровень больше 10, то впустить в клуб, иначе выгнать.

            /*
            int moneyPlayer;
            int levelPlayer;

            Console.Write("Сколько золота у игрока: ");
            moneyPlayer = Convert.ToInt32( Console.ReadLine());

            Console.Write("Сколько уровень у игрока: ");
            levelPlayer = Convert.ToInt32(Console.ReadLine());

            if (moneyPlayer > 500 || levelPlayer > 10)
            {
                Console.WriteLine("Добро пожаловать в клуб!"+ " Ваш уровень "+levelPlayer+" и ваш достаток в " + moneyPlayer +" золота нам подходит!" );
            }
            else
            {
                Console.WriteLine("Все хорошего, возвращайтесь когда ваш уровень будет выше на "+ (10-levelPlayer+1)+ " или вашего золота будет больше на "+(500-moneyPlayer+1));
            }
            */

            // switch когда в условии больше 2х вариантов

            string day;
            Console.Write("Выберете день недели: ");
            day = Console.ReadLine();

            switch (day)
            {
                case "Понедельник":
                    Console.WriteLine("Проводим занятия");
                    break;
                case "Вторник":
                    Console.WriteLine("Выполняем ДЗ");
                    break;
                case "Среда":
                    Console.WriteLine("Гуляем с собакой");
                    break;
                case "Четверг":
                    Console.WriteLine("Посещаем парк");
                    break;
                case "Пятница":
                    Console.WriteLine("Расслабляемся перед выходными");
                    break;
                case "Суббота":
                case "Воскресенье":
                    Console.WriteLine("Тусим");
                    break;
                // когда нет вариантов из case
                default:
                    Console.WriteLine("Я не знаю такой день недели");
                    break;

            }



        }
    }
}

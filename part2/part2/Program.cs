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

            /*
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
            */

            // проверка пароля
            /*
            string password = "sp001";
            string userInput;

            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Вы вошли в программу!");

            }
            else
            {
                Console.WriteLine("Доступ запрещен");
            }
            */

            // конвертер валют
            /*
            int rubToUsd = 65, usdToRub = 67;
            float rub;
            float usd;
            string userInput;
            float currencyCount;

            Console.Write("Сколько у вас рублей? ");
            rub = Convert.ToSingle( Console.ReadLine());

            Console.Write("Сколько у вас долларов? ");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Здравствуйте, введите 1 если хотите обменять" +
                " рубли на доллары, или 2 если хотите обменять доллары на рубли: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Обмен рублей на доллары. Сколько вы хотите обменять? ");
                    currencyCount = Convert.ToSingle( Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else {
                        Console.WriteLine("У вас не достаточно рублей.");
                            }

                    break;
                case "2": 
                    Console.Write("Обмен долларов на рубли. Сколько вы хотите обменять? ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());  
                    if (usd>=currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно долларов.");
                    }

                    break;
            }

            Console.WriteLine("Ваш баланс, Доллары: "+ usd+ " и Рубли: "+rub);

            */

            // Циклы

            /*
            
            int age = 10;
            // выполняется пока верно условие
            
              while (age > 0) {
                Console.WriteLine("С днем рождения");
                // уменьшаем на 1  постфиксный оператор декремента (x--) и префиксный оператор декремента (--x).

                Console.WriteLine(age);
                age--;
            }
            */


            // декремент в условии


            /*
            while (age-- > 0)
            {
                // Console.WriteLine(age);
                // Console.WriteLine("С днем рождения!");
                // преравать цикл в соотвествии с условием
                if (age == 5)
                {
                    break;
                }
                // пропустить одно выполнение цикла -итерацию и идти дальше
                if (age == 7)
                {
                    continue;
                }
                Console.WriteLine(age);
                // Console.WriteLine("С днем рождения!");
            }

            */

            /*

            int testDig = 100;
            while ((testDig = testDig-5) > 0)
            {
                if (testDig == 40)
                {
                    Console.WriteLine("Противник зашел с другой стороны, теряя здоровье");
                    continue;

                }
                if ((testDig % 10) == 0)
                {
                    Console.WriteLine("Пиу - не попали " + testDig);

                }
                else
                {

                    Console.WriteLine("Пиу - попали - " + testDig);
                }
               
                if (testDig == 10)
                {
                    Console.WriteLine("Противник убегает");
                    break;
                }
            }
            */

            // while цикл с условием (например для меню игры, при кнопке выход - выходит из цикла.)

            // for цикл с параметром если есть четкий шаг и границы цикла
            // каждое четное от 0 до 10
            /*
            int age = 10;
            for (int i = 0; i<=age; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int tryCount = 5;
            string password = "123456";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль:");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Доступ открыт");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка, у Вас осталось - " + (tryCount - i - 1) + " попыток ввода");
                }
                if ((tryCount - i - 1) == 0)
                {
                    Console.WriteLine("Доступ закрыт, у вас больше нет возможности вводить пароль");
                }
            }
            */

            // проценты на вклад в банке

            float money;
            int years;
            int percent;

            Console.Write("Введите сколько денег вы хотите внести: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество лет для вклада: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("За "+ (i+1) + " год, вы заработаете "+ money);
                Console.ReadKey();
            }

            Console.WriteLine("Через "+ years+ " лет у Вас накопиться "+ money+ " денежных средств.");



        }

    }
}

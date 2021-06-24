﻿using System;
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
            /*
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
            */

            // бой с противником
            /*
            int health = 1000;
            int damage = 7;
            int enemyHealth = 500;
            int enemyDamage = 14;

            while (health > 0 && enemyHealth > 0)
            {
                health -= enemyDamage;
                enemyHealth -= damage;
                Console.WriteLine("Герой - " + health + ", Враг - " + enemyHealth);

            }
            if (health <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья");

            }
            else if (health <= 0)
            {
                Console.WriteLine("Враг победил");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Герой победил");
            }

            */


            // random

            /*
            Random rand = new Random();
            // 10 не включается последняя цифра
            int i;

            while (true)
            { 
                // от 0 до 10
                i = rand.Next(0, 10);
                Console.WriteLine(i);
                Console.ReadKey();    
            }
            */

            // ошибка использования random в цикле

            /*
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                // внутри цикла будут генерироваться в большинстве одни и те же числа, нужно выносить вне цикла
                // Random rand = new Random();
                Console.WriteLine(rand.Next(0, 50));
            }
            */

            // угадай число

            /*
             
            int number, lower, larger, userInput;
            int tryCount = 5;

            Random rand = new Random();
            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            larger = rand.Next(number + 1, number + 10);



            Console.WriteLine("Мы загадали число от 0 до 100, оно больше " + lower + " но меньше " + larger);

            
            for (int i = 0; i < tryCount; i++)
            {

                Console.Write("Какое это число? ");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number )
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                else if (i < 4)
                {
                    Console.WriteLine("Вы не угадали! У вас осталось "+ (4 - i) +" попыток");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, мы загадали число " + number);
                }


                

            }
            */

            // с урока через while

            // начало уменьшение потом сравнение, поэтому в конце уходит в -1

            /*
            while (tryCount-- > 0)
            {
                Console.Write("Какое это число? ");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали! У вас осталось " + (tryCount) + " попытки");
                }
                
            }

            if (tryCount < 0)
            
                {
                    Console.WriteLine("Мы загадали число " + number);
                }
            
            */

            // gladiator game

            /*
            Random rand = new Random();

            decimal health1Decimal, health2Decimal; ;
            float health1 = rand.Next(90, 110);
            int damage1 = rand.Next(10, 15);
            int armor1 = rand.Next(35, 45);
            float health2 = rand.Next(70, 90);
            int damage2 = rand.Next(10, 25);
            int armor2 = rand.Next(25, 45);

            Console.WriteLine("Гладиатор 1 - HP - " + health1 + ", урон - " + damage1 + ", броня - " + armor1 + "%");
            Console.WriteLine("Гладиатор 2 - HP - " + health2 + ", урон - " + damage2 + ", броня - " + armor2 + "%");

            while (health1 > 0 && health2 > 0)
            {
                
                // конвертируем чтобы не было 0 результата при делении на 100
                health1 -= Convert.ToSingle(rand.Next(0, damage2)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;

                // вывод в десятичной красивой форме https://stackoverflow.com/questions/20968638/how-to-round-a-float-value-in-c
                health1Decimal = Math.Round((decimal)health1);
                health2Decimal = Math.Round((decimal)health2);

                Console.WriteLine("Гладиатор 1 - " + health1Decimal + " HP" + ", Гладиатор 2 - " + health2Decimal + " HP.");

            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Разменялись...");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Победил Гладиатор 2");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Победил Гладиатор 1");

            }

            */

            // console
            // cw tab+tab Console.WriteLine();

            // \b Backspace  \n Новая строка \r Возврат каретки \t Горизонтальная табуляция \v Вертикальная табуляция \"

            //  Console.WriteLine("Привет Максим!\b \nКуда ты вчера делся?\b \nЯ убежал к..\b \b");
            // Console.Clear();
            // Console.SetCursorPosition(11, 22);
            // Console.ForegroundColor = ConsoleColor.Blue;
            // Console.BackgroundColor = ConsoleColor.Gray;
            // Console.Clear();
            // Console.SetCursorPosition(5, 1);
            // Console.WindowWidth = 50;
            // Console.WindowHeight = 30;


            // HomeWork
            // освоение циклов
            // Напишите простейшую программу, которая выводит указанное(установленное) пользователем сообщение заданное количество раз.
            //  TextCount
            /*
            string textUser;
            int textCount;
            Console.WriteLine("Введите сообщение:");
            textUser = Console.ReadLine();
            Console.Write("Напишите сколько раз выводить сообщение: ");
            textCount = Convert.ToInt32(Console.ReadLine());

            while (textCount > 0 ) 
            {
                Console.WriteLine(textUser);
                textCount--;
            }

            */

            // Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
            // Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
            // Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
            // SimpleExit
            /*
            string message;

            Console.WriteLine("Запуск программы....");

            while (true)
            {
                Console.Write("Введите пароль для остановки программы:");
                message = Console.ReadLine();
                if (message == "exit")
                {
                    Console.WriteLine("Программа остановлена!");
                    commandStartProgramm = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Не верная команда, программа выполняется!");
                }

            }
            */

            // Конвертер валют Currency Converter
            // Написать конвертер валют (3 валюты).
            // У пользователя есть баланс в каждой из представленных валют.
            // Он может попросить сконвертировать часть баланса с одной валюты в другую.
            // Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.
            // Курс конвертации должен быть просто прописан в программе.
            // Программа должна завершиться тогда, когда это решит пользователь.
            /*
            float userRub;
            float userUsd;
            float userEur;
            string convertCur;
            string convertCurNeed;
            float curRubUsd = 75.25f;
            float curRubEur = 85.34f;
            float curUsdRub = 73.44f;
            float curUsdEur = 1.3f;
            float curEurUsd = 1.2f;
            float curEurRub = 82.12f;
            int countCur;
            string choice;
            // ToSingle для float
            // проблема с дробными числами, надо исключения какие то продумать...
            Console.Write("Введите сколько у вас RUB: ");
            userRub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас USD: ");
            userUsd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас EUR: ");
            userEur = Convert.ToSingle(Console.ReadLine());

            while (true)
            {
            Console.WriteLine("У Вас на руках: RUB: "+userRub+", USD: "+userUsd+", EUR: "+userEur);
            Console.WriteLine("Курсы валют на сегодня: \n RUB --> USD: " + curRubUsd + " \n USD --> RUB: " + curUsdRub + "\n RUB --> EUR: "+curRubEur+ "\n EUR --> RUB: "
                + curEurRub+ "\n USD --> EUR: "+ curUsdEur+ "\n EUR --> USD: "+ curEurUsd);

            Console.Write("Какую валюту вы хотите сконвертировать (RUB, USD, EUR): ");
            convertCur = Console.ReadLine();

            // После выбора валюты пользователю надо предоставить две другие валюты...

            if (convertCur == "RUB")
            {
                Console.Write("Вы можете конвертировать RUB в USD или EUR, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать RUB: ");
                countCur = Convert.ToInt32(Console.ReadLine());
                if (countCur > userRub)
                {
                    Console.WriteLine("Указанное количество RUB - "+ countCur + " больше вашего баланса" + userRub +" , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "USD")
                {
                    Console.WriteLine("Конвертируем "+ countCur + " RUB в USD по текущему курсу - " + curRubUsd);
                    userRub -= countCur; 
                    userUsd += countCur / curRubUsd;
                }
                if (convertCurNeed == "EUR")
                {
                    Console.WriteLine("Конвертируем " + countCur + " RUB в EUR по текущему курсу - " + curRubEur);
                    userRub -= countCur;
                    userEur += countCur / curRubEur;

                }

            }

            // После выбора валюты пользователю надо предоставить две другие валюты...
            if (convertCur == "USD")
            {
                Console.Write("Вы можете конвертировать USD в RUB или EUR, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать USD: ");
                countCur = Convert.ToInt32(Console.ReadLine());

                if (countCur > userUsd)
                {
                    Console.WriteLine("Указанное количество USD - " + countCur + " больше вашего баланса" + userUsd + " , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "RUB")
                {
                    Console.WriteLine("Конвертируем " + countCur + " USD в RUB по текущему курсу - " + curUsdRub);
                    userUsd -= countCur;
                    userRub += countCur * curUsdRub;
                }
                if (convertCurNeed == "EUR")
                {
                    Console.WriteLine("Конвертируем " + countCur + " USD в EUR по текущему курсу - " + curUsdEur);
                    userUsd -= countCur;
                    userEur += countCur * curUsdEur;

                }

            }

            // После выбора валюты пользователю надо предоставить две другие валюты...
            if (convertCur == "EUR")
            {
                Console.Write("Вы можете конвертировать EUR в RUB или USD, введите наименование валюты: ");
                convertCurNeed = Console.ReadLine();
                Console.Write("Сколько вы хотите конвертировать EUR: ");
                countCur = Convert.ToInt32(Console.ReadLine());

                if (countCur > userEur)
                {
                    Console.WriteLine("Указанное количество EUR - " + countCur + " больше вашего баланса" + userEur + " , введите сумму меньше!");
                    countCur = Convert.ToInt32(Console.ReadLine());

                }


                if (convertCurNeed == "RUB")
                {
                    Console.WriteLine("Конвертируем " + countCur + " EUR в RUB по текущему курсу - " + curEurRub);
                    userEur -= countCur;
                    userRub += countCur * curEurRub;
                }
                if (convertCurNeed == "USD")
                {
                    Console.WriteLine("Конвертируем " + countCur + " EUR в USD по текущему курсу - " + curEurUsd);
                    userEur -= countCur;
                    userUsd += countCur  curEurUsd;

                }

            } 

                // Вывод
                Console.WriteLine("У Вас " + userRub + " RUB, " + userUsd + " USD, " + userEur + " EUR.");


                Console.Write("Вы хотите еще что то конвертировать? (Нажмите любую клавишу или напишите NO): ");
                choice = Console.ReadLine();
                if (choice == "NO")
                {
                    break;
                }



            }

            */


            /*
            // Конвертер валют Currency_Converter_ver2 через switch case

            float userRub;
            float userUsd;
            float userEur;
            string userChoiceСur;
            string userChoiceCurConvert;
            float userCurCount;
            string toExit;

            // курсы
            float rubToUsd = 75;
            float usdToRub = 73;

            float rubToEur = 85;
            float eurToRub = 83;

            float usdToEur = 1.2f;
            float eurToUsd = 1.1f;


            Console.Write("Введите сколько у вас RUB: ");
            userRub = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас USD: ");
            userUsd = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сколько у вас EUR: ");
            userEur = Convert.ToSingle(Console.ReadLine());


            while (true)
            {
                Console.WriteLine("\n\nКурсы на сегодня: \n RUB >> USD: " + rubToUsd 
                    + "\n USD >> RUB: " + usdToRub
                    + "\n RUB >> EUR: " + rubToEur
                    + "\n EUR >> RUB: " + eurToRub
                    + "\n USD >> EUR: " + usdToEur
                    + "\n EUR >> USD: "+eurToUsd );

                Console.Write("\nКакую валюту вы хотите обменять RUB (1), USD (2), EUR (3): ");
                userChoiceСur = Console.ReadLine();

                switch (userChoiceСur)
                {
                    // RUB
                    case "1":
                        Console.Write("\n\nНа какую валюту вы хотите поменять RUB? USD (1) или EUR (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько RUB вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userRub < userCurCount)
                        {
                            Console.WriteLine("У вас не достаточно RUB! Введите сумму меньше " + userRub);
                            break;
                        }

                        switch (userChoiceCurConvert)
                        {
                            // RUB >> USD
                            case "1":
                                    userRub -= userCurCount;
                                    userUsd += userCurCount / rubToUsd;
                                break;
                            // RUB >> EUR
                            case "2":
                                userRub -= userCurCount;
                                userEur += userCurCount / rubToEur;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }

                        break;
                    // USD
                    case "2":
                        Console.Write("\n\nНа какую валюту вы хотите поменять USD? RUB (1) или EUR (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько USD вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userUsd < userCurCount )
                        {
                            Console.WriteLine("У вас не достаточно USD! Введите сумму меньше "+ userUsd);
                            break;
                        }

                        switch (userChoiceCurConvert)
                        {
                            // USD >> RUB
                            case "1":
                                userUsd -= userCurCount;
                                userRub += userCurCount * usdToRub;
                                break;
                            // USD >> EUR
                            case "2":
                                userUsd -= userCurCount;
                                userEur += userCurCount / usdToEur;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }

                        break;
                    // EUR
                    case "3":
                        Console.Write("\n\nНа какую валюту вы хотите поменять EUR? RUB (1) или USD (2): ");
                        userChoiceCurConvert = Console.ReadLine();
                        Console.Write("Сколько EUR вы хотите обменять: ");
                        userCurCount = Convert.ToSingle(Console.ReadLine());

                        if (userEur < userCurCount)
                        {
                            Console.WriteLine("У вас не достаточно EUR! Введите сумму меньше " + userEur);
                            break;
                        }
                        switch (userChoiceCurConvert)
                        {
                            // EUR >> RUB
                            case "1":
                                userEur -= userCurCount;
                                userRub += userCurCount * eurToRub;
                                break;
                            // EUR >> USD
                            case "2":
                                userEur -= userCurCount;
                                userUsd += userCurCount * eurToUsd;
                                break;

                            default:
                                Console.WriteLine("Вы не верно выбрали валюту для обмена!");
                                break;
                        }


                        break;
                    default:
                        Console.WriteLine("Вы ввели не верную валюту");

                        break;

                }

                Console.WriteLine("\n\nПосле обмена у вас на руках RUB: " + userRub + ", USD: " + userUsd + ", EUR: " + userEur);

                Console.Write("\n\nНажмите любую клавишу для продолжения!\n" +
                    "Если желаете выйти, напишите 1: ");
                toExit = Console.ReadLine();

                if (toExit == "1")
                {
                    break;
                }


            }
            */


            // Конвертер валют Currency_Converter_ver3 через switch case и валютные пары
            /*
            float userRUB;
            float userUSD;
            float userEUR;
            string choiceCurUser;
            float choiceCurCountUser;
            string exitConv;

            float curRUBToUSD = 75;
            float curUSDToRUB = 73;
            float curRUBToEUR = 88;
            float curEURToRUB = 85;
            float curEURToUSD = 1.1f;
            float curUSDToEUR = 1.2f;

            // меняем цвет текста
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Сколько у вас RUB: ");
            userRUB = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас USD: ");
            userUSD = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас EUR: ");
            userEUR = Convert.ToSingle(Console.ReadLine());
            //float.Parse аналогично Convert.ToSingle

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Курсы на сегодня:\n" + "RUB >> USD - " + curRUBToUSD + "\nUSD >> RUB - " + curUSDToRUB +
                    "\nRUB >> EUR - " + curRUBToEUR + "\nEUR >> RUB - " + curEURToRUB + "\nEUR >> USD - " + curEURToUSD +
                    "\nUSD >> EUR - " + curUSDToEUR);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Выберите что вы хотите обменять:\n" +
                    "RUB >> USD напишите 1,\n" +
                    "USD >> RUB напишите 2,\n" +
                    "RUB >> EUR напишите 3,\n" +
                    "EUR >> RUB напишите 4,\n" +
                    "EUR >> USD напишите 5,\n" +
                    "USD >> EUR напишите 6,\n"
                    );
                choiceCurUser = Console.ReadLine();

                Console.Write("Сколько вы хотите поменять валюты: ");
                choiceCurCountUser = Convert.ToSingle(Console.ReadLine());

                switch (choiceCurUser)
                {
                    // RUB >> USD
                    case "1":
                        if (userRUB >= choiceCurCountUser)
                        {
                            userRUB -= choiceCurCountUser;
                            userUSD += choiceCurCountUser / curRUBToUSD;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " RUB в USD.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько RUB для обмена, введите число меньше: " + userRUB);
                            break;
                        }


                    // USD >> RUB
                    case "2":
                        if (userUSD >= choiceCurCountUser)
                        {
                            userUSD -= choiceCurCountUser;
                            userRUB += choiceCurCountUser * curUSDToRUB;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " USD в RUB.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userUSD);
                            break;
                        }

                    // RUB >> EUR
                    case "3":
                        if (userRUB >= choiceCurCountUser)
                        {
                            userRUB -= choiceCurCountUser;
                            userEUR += choiceCurCountUser / curRUBToEUR;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " RUB в EUR.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userRUB);
                            break;
                        }

                    // EUR >> RUB
                    case "4":
                        if (userEUR >= choiceCurCountUser)
                        {
                            userEUR -= choiceCurCountUser;
                            userRUB += choiceCurCountUser * curEURToRUB;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " EUR в RUB.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько EUR для обмена, введите число меньше: " + userEUR);
                            break;
                        }

                    // EUR >> USD
                    case "5":
                        if (userEUR >= choiceCurCountUser)
                        {
                            userEUR -= choiceCurCountUser;
                            userUSD += choiceCurCountUser * curEURToUSD;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " EUR в USD.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько EUR для обмена, введите число меньше: " + userEUR);
                            break;
                        }

                    // USD >> EUR
                    case "6":
                        if (userUSD < choiceCurCountUser)
                        {
                            userUSD -= choiceCurCountUser;
                            userEUR += choiceCurCountUser * curUSDToEUR;

                            Console.WriteLine("Конвертируем " + choiceCurCountUser + " USD в EUR.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У Вас нет столько USD для обмена, введите число меньше: " + userUSD);
                            break;
                        }
                    // Можно сделать 7 и 8 пункты для инфо по счетам и выхода, но придется в каждый кейс дописывать ввод валюты choiceCurCountUser
                    // Wrong way
                    default:
                        Console.WriteLine("Вам нужно выбрать пункт от 1 до 6, вы ошиблись с выбором валютной пары!");
                        break;
                }

                Console.WriteLine("В результате обмена у вас на руках RUB: " + userRUB + ", USD: " + userUSD + ", EUR: " + userEUR);

                Console.WriteLine("Напишите \"1\" для выхода! Или нажмите любую клавишу чтобы продолжить обмен.");
                exitConv = Console.ReadLine();
                if (exitConv == "1")

                {
                    break;
                }

            }
            */



            // Консольное меню
            // При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды.
            // Т.е.вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
            // Примеры команд(требуется 4 - 6 команд, придумать самим):
            // SetName – установить имя;
            // ChangeConsoleColor - изменить цвет консоли;
            // SetPassword – установить пароль;
            // WriteName – вывести имя(после ввода пароля);
            // Esc – выход из программы.
            // Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.


            // console_ver1
            /*
            int inputMenu;
            string name = "";
            string password = "";
            int windowSizeWidth;
            int windowSizeHeight;

            windowSizeWidth = 180;
            windowSizeHeight = 30;

            while (true)
            {
                Console.WriteLine("SetName(1)|ChangeConsoleColor(2)|SetPass(3)|WriteName(4)|WindowSize(5)|Title(6)|whatWinSize(7)|Beep(8)|RColor(9)|Exit(10)");
                inputMenu = Convert.ToInt32(Console.ReadLine());


                switch (inputMenu)
                {
                    case 1:
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Имя задано, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Цвет фона изменен, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Установите пароль: ");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль задан, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Введите пароль: ");
                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Добро пожаловать, " + name + " Нажмите любую клавишу");
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case 5:
                        // Console.WindowWidth = 50;
                        // Console.WindowHeight = 30;
                        Console.Write("Введите ширину окна, например 120: ");
                        windowSizeWidth = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите высоту окна, например 30: ");
                        windowSizeHeight = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WindowWidth = windowSizeWidth;
                        Console.WindowHeight = windowSizeHeight;
                        break;
                    case 6:
                        Console.Write("Задайте название для окна: ");
                        Console.Title = Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Текущие размеры окна: "+Console.WindowHeight+ " на "+ Console.WindowWidth);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Beep();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case 10:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Не верная команда");
                        Console.Clear();
                        break;
                }
                if (inputMenu == 10)
                {
                    break;
                }

            }

            */

            // Последовательность
            // Нужно написать программу(используя циклы, обязательно пояснить выбор вашего цикла),
            // чтобы она выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98

            // есть четкие границы цикл for
            /*
            int sequence = 0;
            for (int i = 0; i < 14; i++)
            {
                sequence += 7;
                // Console.WriteLine(sequence);
                Console.Write(sequence + " ");
            }
            */

            // Вывод имени
            // Вывести имя в прямоугольник из символа, который введет сам пользователь.
            // Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.
            // Пример:
            // Alexey
            // %
            //
            // %%%%%%
            // % Alexey %
            // %%%%%%
            //
            // Примечание:
            // Длину строки можно всегда узнать через свойство Length
            // string someString = “Hello”;
            // Console.WriteLine(someString.Length); //5
            /*
            string name;
            char symbol;

            Console.Write("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ:  ");
            symbol = Convert.ToChar( Console.ReadLine());
            
            
            for (int i = 0; i < name.Length+4; i++)
            {
                Console.Write(symbol);

            }

            Console.Write("\n"+symbol+" "+name+ " "+symbol+"\n");

            for (int i = 0; i < name.Length+4; i++)
            {
                Console.Write(symbol);

            }
            Console.Write("\n");
            */

            // Программа под паролем
            // Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению.
            // Пользователь вводит пароль, далее происходит проверка пароля на правильность,
            // и если пароль неверный, то попросите его ввести пароль ещё раз.
            // Если пароль подошёл, выведите секретное сообщение.
            // Если пользователь неверно ввел пароль 3 раза, программа завершается.

            // PasswordCheck_v1
            /*
            int i = 0;
            string password = "666";
            Console.WriteLine("Доступ закрыт!");
            while (true)
            {
                
                Console.Write("Введите пароль:");
                
                if (password == Console.ReadLine() && i <= 2)
                {
                    Console.WriteLine("Секретное сообщение: И приснился мне, город с незнакомыми людьми, вышли все под дождь...");
                    break;
                }
                else if (i < 2)
                {
                    i += 1;
                }
                else 
                {
                    Console.WriteLine("Количество попыток закончилось.");
                    break;
                }

            }
            */

            // PasswordCheck_v2
            /*
            string password = "666";
            Console.WriteLine("Доступ закрыт!");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль:");
                // Object.Equals Метод Определяет, равны ли два экземпляра объекта. person1.Equals(person2) 
                if (!password.Equals( Console.ReadLine() ) )
                {
                    Console.WriteLine("Не верный пароль");
                }
                else
                {
                    Console.WriteLine("Секретное сообщение: И приснился мне, город с незнакомыми людьми, вышли все под дождь...");
                    break;
                }
            }
            */

            // Бой с боссом
            // Легенда: Вы – теневой маг(можете быть вообще хоть кем) и у вас в арсенале есть несколько заклинаний,
            // которые вы можете использовать против Босса.Вы должны уничтожить босса и только после этого будет вам покой.
            // Формально: перед вами босс, у которого есть определенное кол - во жизней и определенный ответный урон.
            // У вас есть 4 заклинания для нанесения урона боссу.Программа завершается только после смерти босса или смерти пользователя.
            // Пример заклинаний
            // Рашамон – призывает теневого духа для нанесения атаки(Отнимает 100 хп игроку)
            // Хуганзакура(Может быть выполнен только после призыва теневого духа), наносит 100 ед.урона
            // Межпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп.Урон босса по вам не проходит
            // Заклинания должны иметь схожий характер и быть достаточно сложными, они должны иметь какие-то условия выполнения(пример -Хуганзакура).
            // Босс должен иметь возможность убить пользователя.

            // BossFighter_v1

            Random rand = new Random();

            int bossHealth = rand.Next(10000, 20000);
            int bossDamage = rand.Next(300, 500);
            int playerHealth = rand.Next(450, 850);

            int spell;
            int spellOne = rand.Next(50, 100);
            bool spirit = false;
            int spellTwo = rand.Next(300, 800);
            int spellThree = rand.Next(50, 100);
            int spellFour = rand.Next(100, 120);
            int spellFourEnd = rand.Next(15, 90);
            bool sucksSpellFour = false;
            int spellFive = 1;
            bool attackspellFive = false;
            bool flagSpellThree = false;

            int attackbossDamage;
            int attackSpellThree;
            int iFour = 0;
            int iFive = 0;

            Console.WriteLine("Вы вышли на бой с Боссом!");
            Console.WriteLine("Health Boss: " + bossHealth + ", Damage: " + bossDamage + " | Your Health: " + playerHealth);
            // Console.WriteLine("Сила заклинаний: \nРашамон " + spellOne + ", \nХуганзакура "
            //   + spellTwo + ", \nРазлом " + spellThree + ", \nАвертула " + spellFour + "-" + spellFourEnd + ", " + "\nКарабанжа " + spellFive);

            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("\n**********************************************************************************");
                Console.Write("Выбери номер заклинания - Рашамон(1), Хуганзакура(2), Разлом(3), Авертула(4), Карабаранжа(5): ");
                spell = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("**********************************************************************************\n");
                switch (spell)
                {
                    // Рашамон - призывает теневого духа для нанесения атаки -50хп игроку
                    case 1:
                        Console.WriteLine("Вызывается теневой дух " + spellOne + " HP отнимается у Вас!");
                        playerHealth -= spellOne;
                        spirit = true;
                        flagSpellThree = false;
                        break;
                    // Хугунзакура - 100 урона от теневого духа, только если теневой дух вызван.
                    case 2:
                        if (spirit)
                        {
                            bossHealth -= spellTwo;
                            Console.WriteLine("Вы снесли Боссу " + spellTwo + " HP!");
                            spirit = false;
                        }
                        else
                        {
                            Console.WriteLine("Дух не вызван, сначала произнесите Рашамон!");
                        }
                        flagSpellThree = false;
                        break;
                    // Разлом - скрыться и восстановить 250 хп, урона от босса нет, нельзя использовать 2 раза подряд
                    case 3:
                        if (flagSpellThree == false)
                        {
                            attackSpellThree = rand.Next(50, spellThree);
                            playerHealth += attackSpellThree;
                            Console.WriteLine("Вы восстановили " + attackSpellThree + " HP");
                            // используем спел уклонения
                            spellFive = 0;
                            flagSpellThree = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя использовать Авертула 2 раза подряд!");
                            break;
                        }
                    // Авертула - высасывать душу из босса, разово снимет 60хп и пополнит их герою дополнительно будет отниматься следующие 2 атаки по 30 хп. Можно выполнить если нет теневого духа.
                    case 4:

                        Console.WriteLine("Вы высасываете душу у босса, он потерял и вы восстановили " + spellFour + " HP!");
                        Console.WriteLine("На босса наложено заклятие");
                        bossHealth -= spellFour;
                        playerHealth += spellFour;
                        sucksSpellFour = true;
                        flagSpellThree = false;
                        break;


                    // Карабаранжа - отразить удар босса, хп не снимется, но следующая атака босса будет на 50% ниже по урону. выполняется если босс не под проклятием. 
                    case 5:
                        if (sucksSpellFour == false)
                        {
                            spellFive = 0;
                            attackspellFive = true;
                        }
                        flagSpellThree = false;
                        break;

                }

                if (sucksSpellFour)
                {

                    if (iFour >= 1)
                    {
                        bossHealth -= spellFourEnd;

                        playerHealth += spellFour;
                        Console.WriteLine("При высасывании души босс дополнительно теряет, а Вы получаете " + spellFourEnd + " HP");
                    }
                    iFour += 1;

                    if (iFour == 3)
                    {
                        sucksSpellFour = false;
                        Console.WriteLine("Заклятие с босса снято!");
                        iFour = 0;
                    }



                }


                // Boss attack
                attackbossDamage = rand.Next(90, bossDamage) * spellFive;
                // attackspellFive
                if (attackspellFive)

                {
                    if (iFive == 1)
                    {
                        attackbossDamage = attackbossDamage / 2;
                        Console.WriteLine("Урон босса уменьшен в 2 раза!");

                    }
                    iFive += 1;
                    if (iFive == 2)
                    {
                        attackspellFive = false;
                        iFive = 0;
                    }
                }


                // spellFive обнуляем действие 5 спела
                spellFive = 1;


                Console.WriteLine("Босс наносит удар: " + attackbossDamage);
                playerHealth -= attackbossDamage;


                Console.WriteLine("Health Boss: " + bossHealth + " | Your Health: " + playerHealth + "\n");

            }

            if (bossHealth <= 0 && playerHealth <= 0)
            {
                Console.WriteLine("Оба мертвы");
            }
            else if (bossHealth <= 0)
            {
                Console.WriteLine("Вы победили Босса!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Вы проиграли!");
            }





        }

    }
}

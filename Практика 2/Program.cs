using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1");

            Console.WriteLine("Введите число: ");
            int b = int.Parse(Console.ReadLine());

            if (b > 0)
            {
                b = b + 5;

                Console.WriteLine("Положительное: " + b);
            }

            else
            {
                b = b - 5;
                Console.WriteLine("Отрицательное: " + b);
            }


            Console.WriteLine();
            Console.WriteLine("Задание 1.2");

            Console.WriteLine("Введите 1 число: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 число: ");
            int b3 = int.Parse(Console.ReadLine());

            int max = b1;

            if (b2 > max)
            {
                max = b2;
            }

            if (b3 > max)
            {
                max = b3;
            }

            Console.WriteLine("Наибольшее число: " + max);


            Console.WriteLine();
            Console.WriteLine("Задание 1.3");

            Console.WriteLine("Введите 1 число: ");
            int c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число: ");
            int c2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 число: ");
            int c3 = int.Parse(Console.ReadLine());

            double sum = 0;

            if (c1 > 0)
            {
                sum += c1;
            }

            if (c2 > 0)
            {
                sum += c2;
            }

            if (c3 > 0)
            {
                sum += c3;
            }
            Console.WriteLine("Сумма: " + sum);


            Console.WriteLine();
            Console.WriteLine("Задание 1.4");

            Console.WriteLine("Введите число: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 10)
            {
                x = x * 2;

            }

            else
            {
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine("Полученное число: " + x);


            Console.WriteLine();
            Console.WriteLine("Задание 1.5");

            Console.WriteLine("Введите число от 1 до 7: ");
            int dayn = int.Parse(Console.ReadLine());

            switch (dayn)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
                    Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine("Задание 2.1");

            int num = 200;
            while (num % 17 != 0)
            {
                num++;
            }
            Console.WriteLine("Результат: " + num);

            Console.WriteLine();
            Console.WriteLine("Задание 2.2");

            double km = 10;
            double summakm = km;
            int day = 1;
            while (km < 20)
            {
                km += km * 0.05;
                day++;
            }
            Console.WriteLine($"В {day} день человек пройдет {km} км");

            km = 10;
            day = 1;
            while (summakm < 100)
            {
                km += km * 0.05;
                summakm += km;
                day++;
            }
            Console.WriteLine($"За {day} дней человек пройдет 100км ");


            Console.WriteLine();
            Console.WriteLine("Задание 2.3");

            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {factorial}");


            Console.WriteLine();
            Console.WriteLine("Задание 2.4");
            Console.WriteLine("Введите натуральное число: ");
            int chislo_natur = Convert.ToInt32(Console.ReadLine());
            for (int j = 2; chislo_natur >= j; j++)
            {
                if (chislo_natur % j == 0)
                {
                    Console.WriteLine("Ответ: " + j);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
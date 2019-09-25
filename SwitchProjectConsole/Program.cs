using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                          System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("1 - Расшифровка дня недели");
            Console.WriteLine("2 - Расшифровка месяца");
            Console.WriteLine("3 - Выполнение операций над числами");
            Console.WriteLine("4 - Выход");
            int x = int.Parse(Console.ReadLine());
             

            if (x == 1)
            {
                Console.WriteLine("Введите номер дня");
                int n = int.Parse(Console.ReadLine());
                switch (n)
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
                        Console.WriteLine("Пяница");
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        break;
                    case 7:
                        Console.WriteLine("Воскесенье");
                        break;
                    default:
                        Console.WriteLine("Такого дня недели не существует");
                        break;
                }
            }
            if (x == 2)
            {
                Console.WriteLine("Введите номер месяца");
                int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine("Январь");
                        break;
                    case 2:
                        Console.WriteLine("Февраль");
                        break;
                    case 3:
                        Console.WriteLine("Март");
                        break;
                    case 4:
                        Console.WriteLine("Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Май");
                        break;
                    case 6:
                        Console.WriteLine("Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Июль");
                        break;
                    case 8:
                        Console.WriteLine("Август");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь");
                        break;
                    default:
                        Console.WriteLine("Такого месяца не существует");
                        break;
                }
            }
            if (x == 3)
            {
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Умножение");
                Console.WriteLine("3 - Вычитание");
                Console.WriteLine("4 - Деление");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b");
                double b = Convert.ToDouble(Console.ReadLine());
                double z;
                switch (y)
                {
                    case 1:
                        {
                            z = a + b;
                            Console.WriteLine("a + b = {0}", z);
                            break;
                        }
                    case 2:
                        {
                            z = a * b;
                            Console.WriteLine("a * b = {0}", z);
                            break;
                        }
                    case 3:
                        {
                            z = a - b;
                            Console.WriteLine("a - b = {0}", z);
                            break;
                        }
                    case 4:
                        {
                            z = a / b;
                            Console.WriteLine("a / b = {0}", z);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка");
                            break;
                        }
                }

            }
        
                if (x == 4)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            
        }
    }
}

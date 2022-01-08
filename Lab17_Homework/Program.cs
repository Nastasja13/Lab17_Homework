using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_Homework
{
    /*
     * Создать класс для моделирования счета в банке. 
     * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
     * Класс должен быть объявлен как обобщенный. 
     * Универсальный параметр T должен определять тип номера счета. 
     * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
     * Создать  несколько экземпляров класса, параметризированного различными типам. 
     * Заполнить его поля и вывести информацию об экземпляре класса на печать.
     */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("\tДобро пожаловать в \"Банк ваших надежд\"\n\n" +
                    "Выберите тип номера счёта:\n" +
                    "1. Нажмите клавишу \"N\" - если номер счета цифровой.\n" +
                    "2. Нажмите клавишу \"SS\" - если номер счета буквенно-цифровой.");

                //для генерации случайного дробного числа для баланса
                Random x = new Random();
                decimal balance = Convert.ToDecimal(x.Next(10000000) / 10.0);

                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("\nВведите числовой номер счёта");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите ФИО владельца счёта");
                    string owner = Console.ReadLine();

                    Account<int> account1 = new Account<int>(num, balance, owner);

                    //чтобы программа выводилв метод, используемый внутри класса
                    Console.WriteLine(account1.GetInfo());
                    Console.WriteLine("\nНажмите \"Enter\", чтобы ввести новые данные.\n" +
                        "Для выхода, нажмите любую другую клавишу.");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.WriteLine("\nВведите буквенно-числовой номер счета");
                    string numStr = Console.ReadLine();
                    Console.WriteLine("Введите ФИО владельца счета");
                    string owner = Console.ReadLine();
                    Account<string> account2 = new Account<string>(numStr, balance, owner);
                    Console.WriteLine(account2.GetInfo());
                    Console.WriteLine("\nНажмите \"Enter\", чтобы ввести новые данные.\n" +
                        "Для выхода, нажмите любую другую клавишу.");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Нажмите клавишу \"Enter\", чтобы сделать выбор формата счёта.\n" +
                        "Для выхода, нажмите любую другую клавишу.");                   
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }                                
            }
        }
    }
}

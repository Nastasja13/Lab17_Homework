using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_Homework
{
    class Account<T>
    {
        public T Num { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }

        //конструктор принимает и записывает соответствующие знач-я
        public Account(T num, decimal balance, string owner)
        {
            Num = num;
            Balance = balance;
            Owner = owner;
        }

        //метод возвращает строку, которую можно выводить
        public string GetInfo()
        {
            Console.Clear();
            return $"\n\tДанные по запросу счета в \"Банк ваших надежд\" \n" +
                $"\n Владелец: {Owner} " +
                $"\n Номер счёта: {Num} " +
                $"\n Баланс Вашего счёта: {Balance} ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
//Хорошим называется число, которое делится на сумму своих цифр.
//Реализовать подсчет времени выполнения программы, используя структуру DateTime.

namespace Task6_goodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает количество цифр, которое делится на сумму своих цифр, в диапазоне от 1 до 1 000 000 000.\nНажмите любую клавишу для продолжения..");
            Console.ReadKey();

            DateTime time1 = DateTime.Now;
            int count = 0;

            for (int i = 1; i <= 1_000_000_000; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum = sum + number % 10;
                    number = number / 10;
                }

                if (i % sum == 0)
                {
                    count++;
                }
            }
            DateTime time2 = DateTime.Now;

            Console.WriteLine($"Количество таких цифр составляет {count}.\nВремя работы программы: {time2 - time1}");
            Console.ReadKey();
        }
    }
}

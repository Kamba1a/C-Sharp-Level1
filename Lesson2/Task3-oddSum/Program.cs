using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Task3_oddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает сумму нечетных положительных чисел\n(программа принимает на ввод числа, пока не будет введен 0).");

            int sum = 0;
            int number = 0;

            do
            {
                Console.WriteLine("Введите число:");
                number = int.Parse(Console.ReadLine());

                if (number % 2 != 0 && number > 0)
                {
                    sum = sum + number;
                }
            } while (number != 0);

            Console.WriteLine($"Сумма нечетных положительных чисел составляет: {sum}");
            Console.ReadKey();
        }
    }
}

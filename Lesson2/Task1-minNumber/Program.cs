using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//1. Написать метод, возвращающий минимальное из трех чисел.

namespace Task1_minNumber
{
    class Program
    {

        private static double minNumber(double number1, double number2, double number3)
        {
            double min = number1;
            if (number2 < min)
            {
                min = number2;
            }
            if (number3 < min)
            {
                min = number3;
            }
            return min;
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет минимальное из трех чисел.\nВведите первое число:");
            double number1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double number2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double number3 = Double.Parse(Console.ReadLine());

            double min = minNumber(number1, number2, number3);

            Console.WriteLine($"Минимальное из трех чисел: {min}");
            Console.ReadKey();
        }
    }
}

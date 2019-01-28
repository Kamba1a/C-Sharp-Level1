using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace Task7_ABnumbers
{
    class Program
    {

        static void printAB(int number1, int number2)
        {
            Console.WriteLine($"{number1}");
            number1++;

            if (number1 <= number2)
            {
                printAB(number1, number2);
            }
        }

        static int sumAB(int number1, int number2)
        {
            if (number1 + 1 == number2)
            {
                return number1 + number2;
            }
            else
            {
                return number1 + sumAB(number1 + 1, number2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит на экран числа от a до b (a < b), и подсчитывает их сумму.\nВведите число a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Вывод чисел:");
            printAB(a, b);

            Console.WriteLine($"Сумма этих чисел равна {sumAB(a, b)}");
            Console.ReadKey();
        }
    }
}

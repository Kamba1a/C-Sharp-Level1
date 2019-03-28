using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//2. Написать метод подсчета количества цифр числа.

namespace Task2_numbersQuantity
{
    class Program
    {

        static int numbersQuantity(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает количество цифр в числе.\nВведите целое число:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Число состоит из {numbersQuantity(number)} цифр.");
            Console.ReadKey();
        }
    }
}

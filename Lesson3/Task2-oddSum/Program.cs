using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//2.
//а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел.
//Сами числа и сумму вывести на экран, используя tryParse;

//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

namespace Task2_oddSum
{
    class Program
    {   
        static void Msg(string message)
        {
            Console.WriteLine(message);
        }

        static void Msg(string message, out string inputTxtVar)
        {
            Console.WriteLine(message);
            inputTxtVar = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int sum = 0;
            int number;
            string numberTxt;
            string numbers = "";
                       
            Msg("Программа принимает на ввод числа до тех пор, пока не будет введен 0");
            Msg("Затем программа выводит все нечетные положительные числа и их сумму");

            Msg("Введите число:", out numberTxt);

            while (numberTxt != "0")
            {
                if (int.TryParse(numberTxt, out number))
                {
                    if (number % 2 != 0 && number > 0)
                    {
                        sum = sum + number;
                        numbers = numbers + $"{number} ";
                    }
                }
                else
                {
                    Msg("Введены некорректные данные");
                }
                Msg("Введите число:", out numberTxt);
            }

            Msg($"Вывод чисел:\n{numbers}");
            Msg($"Сумма этих чисел равна {sum}");
            Console.ReadKey();  
        }
    }
}

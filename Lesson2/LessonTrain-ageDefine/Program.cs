using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тренировка - применение конструкции switch/case (переделанное задание из методички).
//С клавиатуры вводится возраст. Требуется написать программу, которая
//правильно определит, какое слово нужно написать после возраста.
//Например: вам 11 лет, вам 21 год, вам 33 года.

namespace LessonTrain_ageDefine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Программа определяет, какое слово написать после возраста (лет/год/года).\nВведите возраст:");
            int age = int.Parse(Console.ReadLine());

            if (age != 11 && age != 12 && age != 13 && age != 14)
            {
                int ageDefine = age % 10;

                switch (ageDefine)
                {
                    case 1: Console.WriteLine($"Вам {age} год."); break;
                    case 2:
                    case 3:
                    case 4: Console.WriteLine($"Вам {age} года."); break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 0: Console.WriteLine($"Вам {age} лет."); break;
                }
            }
            else
            {
                Console.WriteLine($"Вам {age} лет.");
            }
            Console.ReadKey();
        }
    }
}

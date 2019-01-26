using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//Задание 5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

namespace Task5_Print
{
    class Program
    {

        static void Alert(string text)
        {
            int x = Console.WindowWidth / 2 - text.Length / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x,y);
            Console.WriteLine(text);
            Console.ReadKey();
        }

        static string Prompt(string text)
        {
            Console.WriteLine(text);
            string answer = Console.ReadLine();
            return answer;
        }

        static void Main(string[] args)
        {
            string name = Prompt("Ваше имя:");
            string surname = Prompt("Ваша фамилия:");
            string city = Prompt("Ваш город:");

            Alert($"{name} {surname}, {city}");
        }
    }
}

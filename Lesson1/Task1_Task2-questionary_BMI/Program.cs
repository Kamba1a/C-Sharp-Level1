using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.

//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах

namespace Task1_Task2_questionary_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост (см):");
            string height = Console.ReadLine();
            Console.WriteLine("Введите ваш вес (кг):");
            string weight = Console.ReadLine();

            Console.WriteLine("Ваши данные: " + name + " " + surname + ", " + age + " лет, рост " + height + " см, вес " + weight + " кг");
            Console.WriteLine("Ваши данные: {0} {1}, {2} лет, рост {3} см, вес {4} кг", name, surname, age, height, weight);
            Console.WriteLine($"Ваши данные: {name} {surname}, {age} лет, рост {height} см, вес {weight} кг");

            float h = float.Parse(height);
            h = h / 100;
            float m = float.Parse(weight);
            float I = m / (h * h);

            Console.WriteLine($"Ваш индекс массы тела: {I:##.##}");
            Console.ReadKey();
        }
    }
}

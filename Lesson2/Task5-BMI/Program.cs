using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
// и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Task5_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш вес (кг):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш рост (см):");
            double height = double.Parse(Console.ReadLine());

            height = height / 100;
            double BMI = weight / (height * height);

            if (BMI < 18.5)
            {
                double normalWeight = 18.5 * height * height;
                Console.WriteLine($"Ваш индекс массы тела: {BMI:f2}\nВам нужно набрать {(normalWeight - weight):f2} кг");
                Console.ReadKey();
            }
            else if (BMI > 24.99)
            {
                double normalWeight = 24.99 * height * height;
                Console.WriteLine($"Ваш индекс массы тела: {BMI:f2}\nВам нужно похудеть на {(weight - normalWeight):f2} кг");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Ваш индекс массы тела: {BMI:f2}\nВаш вес в норме.");
                Console.ReadKey();
            }
        }
    }
}

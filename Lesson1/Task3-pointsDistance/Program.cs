using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//Задание 3.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

namespace Task3_pointsDistance
{
    class Program
    {

        static float pointsDistance(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x1:");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y1:");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y2:");
            float y2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние между двумя точками с координатами ({x1},{y1}) и ({x2},{y2}) равно {pointsDistance(x1, y1, x2, y2):f2}");
            Console.ReadKey();
        }
    }
}

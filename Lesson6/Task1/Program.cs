using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

namespace Task1
{
    //public delegate double Fun(double x);
    public delegate double Fun2(double x, double a);
    
    class Program
    {
        /// <summary>
        /// Вывод таблицы функции
        /// </summary>
        /// <param name="F">функция</param>
        /// <param name="minX">минимальное значение х</param>
        /// <param name="maxX">максимальное значение х</param>
        /// <param name="minA">значение а</param>
        /// <param name="stepA">шаг изменения а</param>
        public static void Table(Fun2 F, double minX, double maxX, double minA, double stepA)
        {
            double x = minX;
            double a = minA;
            Console.WriteLine("----- X ------- A -------- Y ------");
            while (x <= maxX)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", x, a, F(x, a));
                x += 1;
                a += stepA;
            }
            Console.WriteLine("-----------------------------------");
        }

        /// <summary>
        /// Функция возвращает значение y = x^3
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Функция a*x^2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFunc2(double x, double a)
        {
            return a * (x * x);
        }

        /// <summary>
        /// Функция a*sin(x)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double MyFunc3(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции MyFunc1:");
            Table(MyFunc2, -2, 2, 0, 1);

            Console.WriteLine("Таблица функции MyFunc2:");
            Table(MyFunc3, -2, 2, 0, 1);

            //Console.WriteLine("Таблица функции MyFunc:");
            //Table(MyFunc, -2, 2);

            //Console.WriteLine("Таблица функции Sin:");
            //Table(Math.Sin, -2, 2);

            //Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            //Table(delegate (double x) { return x * x; }, 0, 3);

            Console.ReadKey();
        }    
    }
}

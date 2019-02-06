using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ОЛЬГА НАЗАРОВА
//2. а) Дописать класс для работы с одномерным массивом.
//    Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
//    Создать свойство Sum, которые возвращают сумму элементов массива,
//    метод Inverse, меняющий знаки у всех элементов массива,
//    метод Multi, умножающий каждый элемент массива на определенное число,
//    свойство MaxCount, возвращающее количество максимальных элементов.
//    В Main продемонстрировать работу класса.

//б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

namespace Task2_arrayClass
{
    class MyArray
    {
        int[] arr;

        public MyArray(int length)
        {
            arr = new int[length];
        }

        /// <summary>
        /// конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <param name="firstNumber">начальное значение</param>
        /// <param name="step">шаг</param>
        public MyArray (int length, int firstNumber, int step)
        {
            arr = new int[length];
            arr[0] = firstNumber;
            for (int i = 1; i < length; i++)
            {
                arr[i] = arr[i - 1] + step;
            }
        }

        /// <summary>
        /// конструктор, который загружает данные из файла
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        public MyArray (string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                int length = int.Parse(sr.ReadLine());
                arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Ошибка. На считывание принимаются только целочисленные значения. Каждый элемент массива должен быть в отдельной строке. В первой строке должна быть указана длина массива.");
            }
        }

        /// <summary>
        /// загружает данные в файл
        /// </summary>
        /// <param name="filePath">путь</param>
        public void inFile (string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                sw.WriteLine(arr[i]);
            }
            sw.Close();
        }

        /// <summary>
        /// вывод элементов массива в строку
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// сообщение + вывод элементов массива в строку
        /// </summary>
        /// <param name="msg"></param>
        public void Print(string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// возвращает сумму всех элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// метод Inverse, меняющий знаки у всех элементов массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -arr[i];
            }
        }

        /// <summary>
        /// метод Multi, умножающий каждый элемент массива на определенное число
        /// </summary>
        /// <param name="factor">коэффициент</param>
        public void Multi(int factor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * factor;
            }
        }

        /// <summary>
        /// возвращает количество максимальных элементов массива
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = arr[0];
                int count = 1;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i]>max)
                    {
                        max = arr[i];
                        count=1;
                    }
                    else if (arr[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        /// <summary>
        /// преобразует элементы массива в случайные числа
        /// </summary>
        /// <param name="min">минимальное случайное число</param>
        /// <param name="max">максимальное случайное число</param>
        public void Rand (int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max+1);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 1, 2);
            a.Print("Создан массив A:");

            Console.WriteLine($"Сумма элементов массива: {a.Sum}");

            a.Inverse();
            a.Print("Метод Inverse поменял знаки элементов массива:");

            a.Multi(2);
            a.Print("С помощью метода Multi каждый элемент массива умножен на 2:");

            a.Rand(1, 5);
            a.Print("Меняем элементы массива на случайные для демонстрации свойства MaxCount");

            Console.WriteLine($"Количество максимальных элементов массива: {a.MaxCount}");

            Console.WriteLine("\nВнимание! После нажатия клавиши будет создан текстовый файл D:\\c_sharp_array.txt для демонстрации записи данных в файл и чтения из него.");
            Console.ReadKey();

            a.inFile(@"D:\c_sharp_array.txt");
            MyArray b = new MyArray(@"D:\c_sharp_array.txt");
            a.Print("\nСоздан массив B с помощью считывания данных из файла:");
            Console.ReadKey();
        }
    }
}

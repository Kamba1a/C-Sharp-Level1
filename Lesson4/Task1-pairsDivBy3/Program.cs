using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

namespace Task1_pairsDivBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Массив из случайных чисел от -10000 до 10000:");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10000);
                Console.Write($"{arr[i]} ");
            }

            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"\n\nКоличество пар, в которых хотя бы одно число делится на 3:\n{count}");
            Console.ReadKey();
        }
    }
}

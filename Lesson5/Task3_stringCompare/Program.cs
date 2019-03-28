using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например: badc ​являются перестановкой abcd​.

namespace Task3_stringCompare
{
    class Program
    {
        /// <summary>
        /// метод, определяющий, является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="text1">первая строка</param>
        /// <param name="text2">вторая строка</param>
        /// <returns></returns>
        static bool checkReverse(string text1, string text2)
        {
            char[] arr = text1.ToCharArray();
            Array.Reverse(arr);
            string textReverse = new string(arr);

            return text2.Equals(textReverse);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВведите первую строку:");
                string text1 = Console.ReadLine();
                Console.WriteLine("Введите вторую строку:");
                string text2 = Console.ReadLine();

                if (checkReverse(text1, text2))
                {
                    Console.WriteLine("Одна строка является перестановкой другой.");
                }
                else
                {
                    Console.WriteLine("Строки не являются перестановками друг друга.");
                }
                Console.ReadKey();
            }
        }
    }
}

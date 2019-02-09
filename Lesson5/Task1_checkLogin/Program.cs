using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//ОЛЬГА НАЗАРОВА
//1.
//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов,
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.

namespace Task1_checkLogin
{
    class Program
    {
        #region Методы для выполения пункта а) задачи

        /// <summary>
        /// Проверка символа, является ли он латинской буквой
        /// </summary>
        /// <param name="symbol">символ</param>
        /// <returns></returns>
        public static bool checkIsLatinLetter(char symbol)
        {
            int symbolCode = symbol;
            return symbolCode >= 97 && symbolCode <= 122 || symbolCode >= 65 && symbolCode <= 90;
        }

        /// <summary>
        /// Метод проверки логина на соответствие условию задачи
        /// </summary>
        /// <param name="login">логин</param>
        /// <returns></returns>
        public static bool checkLogin (string login)
        {
            if (login.Length >= 2 && login.Length <= 10 && checkIsLatinLetter(login[0]))
            {
                for (int i = 1; i < login.Length; i++)
                {
                    if (!(checkIsLatinLetter(login[i]) || char.IsNumber(login[i])))
                    {
                        return false;
                    }
                }   
            }
            else
            {
                return false;
            }
            return true;
        }
        #endregion

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                #region а) Проверка логина без использования регулярных выражений
                if (checkLogin(login))
                #endregion

                #region б) Проверка логина с использованием регулярных выражений
                //Regex loginPattern = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");
                //if (loginPattern.IsMatch(login))
                #endregion

                {
                    Console.WriteLine("Логин принят\n");
                }
                else
                {
                    Console.WriteLine("Логин не корректен\n");
                }
            }
        }
    }
}

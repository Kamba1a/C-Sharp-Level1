﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Task4_checkData
{
    class Program
    {

        static bool checkData(string login, string password)
        {
            return (login == "root" && password == "GeekBrains");
        }

        static void Main(string[] args)
        {
            int i = 0;
            do {
                i++;

                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();

                if (checkData(login, password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверные данные");
                }
            } while (i < 3);

            switch (i)
            {
                case 3: Console.WriteLine("Доступ закрыт"); break;
                default: Console.WriteLine("Добро пожаловать!"); break;
            }
            Console.ReadKey();
        }
    }
}

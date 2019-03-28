﻿using System;
using System.Linq;
using System.Threading.Tasks;

//ОЛЬГА НАЗАРОВА
//2. Разработать статический класс ​ Message​ , содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) *** Создать метод, который производит частотный анализ текста.
//  В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//  каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

namespace Task2_messageClass
{

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Кот кошка, кот собака! кот кошка голубь";

            Console.WriteLine($"Исходный текст:\n{text}");
            Console.WriteLine("\nа) Вывести только те слова сообщения, которые содержат не более n (трех) букв:");
            Message.maxWordSize(text, 3);
            Console.WriteLine($"\nб) Удалить из сообщения все слова, которые заканчиваются на заданный символ (т):\n{Message.wordRemove(text, 'т')}");
            Console.WriteLine($"\nв) Найти самое длинное слово сообщения:\n{Message.maxWord(text)}");
            Console.WriteLine($"\nг) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения:\n{Message.maxWordString(text)}");

            string[] array = { "кот", "кошка", "собака", "голубь"};
            Console.WriteLine("\n***Создать метод, который производит частотный анализ текста:");
            Message.textAnalysis(array, text);
            Console.ReadKey();

        }
    }
}

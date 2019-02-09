using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
    public static class Message
    {   

        /// <summary>
        /// Метод создания массива из слов текса
        /// </summary>
        /// <param name="msg">текст</param>
        /// <returns></returns>
        static string[] stringToArray (string msg)
        {
            Regex regex = new Regex(@"\w+");
            string[] msgArray = new string[regex.Matches(msg).Count];
            int i = 0;
            foreach (Match word in regex.Matches(msg))
            {
                msgArray[i] = word.ToString();
                i++;
            }
            return msgArray;
        }

        /// <summary>
        /// а) Вывести только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <param name="wordLength">максимальная длина слова</param>
        public static void maxWordSize(string msg, int wordLength)
        {
            string[] msgArray = stringToArray(msg);

            for (int i = 0; i < msgArray.Length; i++)
            {
                if (msgArray[i].Length <= wordLength)
                {
                    Console.Write($"{msgArray[i]} ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// (возвращает новую строку)
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <param name="symbol">символ</param>
        /// <returns>возвращает новую строку</returns>
        public static string wordRemove(string msg, char symbol)
        {
            string[] msgArray = stringToArray(msg);
            string newMSg = "";

            for (int i = 0; i < msgArray.Length; i++)
            {
                if (msgArray[i][msgArray[i].Length - 1] != symbol)
                {
                    newMSg = newMSg + msgArray[i] + " ";
                }
            }
            newMSg.TrimEnd(' ');
            return newMSg;
        }

        /// <summary>
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// (меняет само сообщение)
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <param name="symbol">символ</param>
        public static void wordRemove(ref string msg, char symbol)
        {
            string[] msgArray = stringToArray(msg);
            for (int i = 0; i < msgArray.Length; i++)
            {
                if (msgArray[i][msgArray[i].Length - 1] == symbol)
                {
                    msg.Replace(msgArray[i], "");
                }
            }
        }

        /// <summary>
        /// //в) Найти самое длинное слово сообщения.
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <returns></returns>
        public static string maxWord (string msg)
        {
            string[] msgArray = stringToArray(msg);
            int max = msgArray[0].Length;
            string word = msgArray[0];

            for (int i = 1; i < msgArray.Length; i++)
            {
                if (msgArray[i].Length > max)
                {
                    max = msgArray[i].Length;
                    word = msgArray[i];
                }
            }
            return word;
        }

        /// <summary>
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <returns></returns>
        public static string maxWordString (string msg)
        {
            StringBuilder maxWords = new StringBuilder();
            string[] msgArray = stringToArray(msg);
            int max = msgArray[0].Length;
            for (int i = 1; i < msgArray.Length; i++)
            {
                if (msgArray[i].Length > max)
                {
                    max = msgArray[i].Length;
                }
            }
            for (int i = 0; i < msgArray.Length; i++)
            {
                if (msgArray[i].Length == max)
                {
                    maxWords.Append(msgArray[i]);
                    maxWords.Append(" ");
                }
            }
            return maxWords.ToString().TrimEnd(' ');
        }

        /// <summary>
        /// ***Создать метод, который производит частотный анализ текста.
        /// требуется использовать класс Dictionary.
        /// </summary>
        /// <param name="array">массив слов</param>
        /// <param name="text">анализируемый текст</param>
        public static void textAnalysis(string[] array, string text)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {   
                Regex regex = new Regex(array[i]);
                dict[array[i]] = regex.Matches(text.ToLower()).Count;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} - {dict[array[i]]}");
            }
        }

    }
}

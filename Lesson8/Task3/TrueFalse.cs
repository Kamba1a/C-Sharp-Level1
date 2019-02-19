using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task3
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {   
        /// <summary>
        /// Текст вопроса
        /// </summary>
        string text;
        /// <summary>
        /// Правда или нет
        /// </summary>
        bool trueFalse;

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get { return text; } set { text = value; } }
        /// <summary>
        /// Правда или нет
        /// </summary>
        public bool TrueFalse { get { return trueFalse; } set { trueFalse = value; } }

        //Пустой конструктор для сериализации
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }

    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<Question> list;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FileName { get { return fileName; } set { fileName = value; } }

        /// <summary>
        /// Индексатор - свойство для доступа к закрытому объекту (вопрос в коллекции)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Question this[int index] { get { return list[index]; } }

        /// <summary>
        /// Возвращает количество вопросов в коллекции
        /// </summary>
        public int Count { get { return list.Count; } }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        /// <summary>
        /// Добавление в коллекцию вопроса
        /// </summary>
        /// <param name="text">Вопрос</param>
        /// <param name="trueFalse">Правда или нет</param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Удаление вопроса из коллекции по индексу
        /// </summary>
        /// <param name="index">индекс вопроса в коллекции</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>
        /// Сохранение коллекции вопросов в xml файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// Загрузка коллекции вопросов из xml файла
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
    }
}
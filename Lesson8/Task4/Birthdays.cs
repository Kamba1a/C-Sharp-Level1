using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task4
{   
    //Класс для сохранения дня рождения человека
    [Serializable]
    public class Man
    {   

        string name;
        DateTime dateOfBirth;
        
        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Дата рождения человека
        /// </summary>
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }


        //Пустой конструктор для сериализации
        public Man()
        {
        }

        public Man(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
    }

    // Класс для хранения списка дней рождений. А также для сериализации в XML и десериализации из XML
    class Birthdays
    {
        string fileName;
        List<Man> list;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FileName { get { return fileName; } set { fileName = value; } }

        /// <summary>
        /// Индексатор - свойство для доступа к закрытому объекту (элемент в коллекции)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Man this[int index] { get { return list[index]; } }

        /// <summary>
        /// Возвращает количество людей в коллекции
        /// </summary>
        public int Count { get { return list.Count; } }

        public Birthdays()
        {
            list = new List<Man>();
        }

        public Birthdays(string fileName)
        {
            this.fileName = fileName;
            list = new List<Man>();
        }

        /// <summary>
        /// Добавление в коллекцию человека
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="day">День</param>
        /// <param name="month">Месяц</param>
        /// <param name="year">Год</param>
        public void Add(string name, DateTime dateOfBirth)
        {
            list.Add(new Man(name, dateOfBirth));
        }

        /// <summary>
        /// Удаление человека из коллекции по индексу
        /// </summary>
        /// <param name="index">индекс человека в коллекции</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>
        /// Сохранение коллекции в xml файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Man>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// Загрузка коллекции из xml файла
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Man>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Man>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
    }
}
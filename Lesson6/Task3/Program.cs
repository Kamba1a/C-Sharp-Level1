using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

//ОЛЬГА НАЗАРОВА

//Файл students_1.csv:
//Имя;Фамилия;Университет;Факультет;Кафедра;Возраст;Курс(1-4 бакалавр; 5-6 магистр);Группа;Город

//3. Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;

namespace Task3
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        // Создаем метод для сравнения экземпляров
        static int lastNameCompare(Student st1, Student st2) 
        {
            return String.Compare(st1.lastName, st2.lastName);
        }

        /// <summary>
        /// метод для сравнения экземпляров по возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int ageCompare(Student st1, Student st2)
        {
            if (st1.age > st2.age) return 1;
            else if (st1.age < st2.age) return -1;
            else return 0;
        }

        /// <summary>
        /// метод для сравнения экземпляров по курсу, а затем по возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int course_ageCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course) return 1;
            else if (st1.course < st2.course) return -1;
            else
            {
                return ageCompare(st1, st2);
            }

        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int students_5_6 = 0;
            int[] arr = new int[6];

            List<Student> list = new List<Student>(); // Создаем список студентов

            StreamReader sr = new StreamReader("students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5)
                    {
                        bakalavr++;
                    }
                    else
                    {
                        magistr++;
                        students_5_6++;
                    }

                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        arr[int.Parse(s[6])]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Исходный список:");
            Console.WriteLine(File.ReadAllText("students_1.csv"));
            Console.WriteLine();

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);

            list.Sort(new Comparison<Student>(lastNameCompare));
            Console.WriteLine("\nСортировка по фамилии:");
            foreach (var v in list) Console.WriteLine(v.lastName);

            Console.WriteLine("\nа) Количество студентов учащихся на 5 и 6 курсах - {0}", students_5_6);

            Console.WriteLine("\nб) Сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) Console.WriteLine($"{i} курс - {arr[i]} студент(а)");
            }

            list.Sort(new Comparison<Student>(ageCompare));
            Console.WriteLine("\nв) Сортировка списка по возрасту студента:");
            foreach (var v in list) Console.WriteLine($"{v.lastName}, {v.age}");

            list.Sort(new Comparison<Student>(course_ageCompare));
            Console.WriteLine("\nг) Сортировка списка по курсу и возрасту студента:");
            foreach (var v in list) Console.WriteLine($"{v.lastName}, {v.course}, {v.age}");

            Console.ReadKey();
        }
    }
}

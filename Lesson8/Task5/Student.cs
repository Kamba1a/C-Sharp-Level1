using System;

//ОЛЬГА НАЗАРОВА
//5.**Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

namespace Task5
{
    [Serializable]
    public class Student
    {
        string firstName;
        string secondName;
        string university;
        string faculty;
        string department;
        int age;
        int course;
        int studyGroup;
        string city;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string University { get { return university; } set { university = value; } }
        public string Faculty { get { return faculty; } set { faculty = value; } }
        public string Department { get { return department; } set { department = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Course { get { return course; } set { course = value; } }
        public int StudyGroup { get { return studyGroup; } set { studyGroup = value; } }
        public string City { get { return city; } set { city = value; } }

        //для сериализации
        public Student()
        {
        }

        public Student(string firstName, string secondName, string university, string faculty, string department, int age, int course, int studyGroup, string city)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.studyGroup = studyGroup;
            this.city = city;
        }
    }
}

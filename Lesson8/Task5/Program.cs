using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

//ОЛЬГА НАЗАРОВА
//5.**Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            StreamReader sr = new StreamReader("students_1.csv");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
            }
            sr.Close();

            //foreach (Student st in students) Console.WriteLine($"{st.FirstName} {st.SecondName} {st.City}"); //итд..
            //Console.ReadKey();

            StreamWriter sw = new StreamWriter("students_1.xml");
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            xmlFormat.Serialize(sw, students);
            sw.Close();
        }
    }
}

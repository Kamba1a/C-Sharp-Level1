using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Reflection;

//ОЛЬГА НАЗАРОВА
//1. С помощью рефлексии выведите все свойства структуры DateTime

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(DateTime);

            foreach (object obj in type.GetProperties())
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}

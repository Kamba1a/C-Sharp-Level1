using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ОЛЬГА НАЗАРОВА
//3.
// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
// * Добавить свойства типа int для доступа к числителю и знаменателю;
// * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.

namespace Task3_fractionsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(15, 275);
            Fraction b = new Fraction();
            b.Numerator = 16;
            b.Denominator = 5;

            Console.WriteLine($"a = {Fraction.Print(a)} = {a.Number}"); //обычный и десятичный вид дроби
            Console.WriteLine($"b = {Fraction.Print(b)} = {b.Number}");

            a = Fraction.Simpl(a); //упрощение дроби
            Console.WriteLine($"Упрощение дроби a: {Fraction.Print(a)}");

            Console.WriteLine($"a + b = {a.Plus(b)}"); //сложение
            Console.WriteLine($"a - b = {a.Minus(b)}"); //вычитание
            Console.WriteLine($"a * b = {a.Multi(b)}"); //умножение
            Console.WriteLine($"a / b = {a.Divis(b)}"); //деление

            Console.ReadKey();

            a.Denominator = 0; // выброс исключения
        }
    }
}

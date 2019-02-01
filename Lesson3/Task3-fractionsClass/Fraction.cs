using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_fractionsClass
{
    class Fraction
    {
        int numerator;
        int denominator;

        //доступ к числителю
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        //доступ к знаменателю
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                checkDenominator(value);
            }
        }

        //десятичная дробь (только чтение)
        public double Number
        {
            get
            {
                return Math.Round((double)numerator / denominator, 2);
            }
        }

        //конструктор со значениями по умолчанию
        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        //конструктор с присвоением значений
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            checkDenominator(denominator);
        }

        //Проверка знаменателя на 0
        void checkDenominator(int denominator)
        {
            switch (denominator)
            {
                case 0: throw new ArgumentException("Знаменатель не может быть равен 0");
                default: this.denominator = denominator; break;
            }
        }

        //Метод возвращает строковое представление дроби вида x/y
        public static string Print(Fraction name)
        {
            return $"{name.numerator}/{name.denominator}";
        }
        
        //Метод сложения дробей
        public double Plus(Fraction name)
        {
            double res = this.Number + name.Number;
            return res;
        }

        //Метод вычитания дробей
        public double Minus(Fraction name)
        {
            double res = this.Number - name.Number;
            return res;
        }

        //Метод умножения дробей
        public double Multi(Fraction name)
        {
            double res = this.Number * name.Number;
            return Math.Round(res, 2);
        }

        //Метод деления дробей
        public double Divis(Fraction name)
        {
            double res = this.Number / name.Number;
            return Math.Round(res, 2);
        }

        //Метод упрощения дроби, возвращает новую дробь
        public static Fraction Simpl(Fraction name)
        {
            Fraction n = new Fraction(name.numerator, name.denominator);
            bool tmp;
            do
            {
                tmp = false;
                for (int i = 9; i > 1; i--)
                {   
                    if (n.numerator % i == 0 && n.denominator % i == 0)
                    {
                        n.numerator = n.numerator / i;
                        n.denominator = n.denominator / i;
                        tmp = true;
                    }
                }
            } while (tmp);
            return n;
        }
    }
}

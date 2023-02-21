using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4_2
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get { 
                return denominator;
            }
            set {
                if (value == 0)
                {
                    denominator = 1;
                }
                else if (value < 0)
                {
                    denominator = value * (-1);
                }
                else { 
                    denominator= value;
                }

            }
        }
        public Fraction(int num, int denom) {
            Numerator = num;
            Denominator= denom;
            Reduction(this);
        }
        public Fraction(int num) : this(num, 1) { }
        public Fraction() : this(0, 1) { }

        public override string ToString()
        {

            return $"{Numerator}/{Denominator}";
        }
        //сумма дробей
        public Fraction AddFraction(Fraction f) {
            if (Denominator == f.Denominator)
            {
                return new Fraction(Numerator + f.Numerator, Denominator);
            }
            return new Fraction(Numerator * f.Denominator + f.Numerator * Denominator, Denominator * f.Denominator);
        }
        //переопределение оператора +
        public static Fraction operator +(Fraction f1, Fraction f2) {
            return f1.AddFraction(f2);
        }
        //разность дробей
        //переопределение оператора -
        //произведение дробей
        //переопределение оператора *
        //деление дробей
        //переопределение оператора /
        //переопределение метода Equals() 
        //переопределение метода GetHashCode() 
        public override int GetHashCode()
        {
            return ToString().GetHashCode(); 
        }
        //переопределение оператора ==
        //переопределение оператора !=
        //сокращение дроби
        private void Reduction(Fraction f)
        {

            int n = f.MaxDiv();
            if (n > 1)
            {
                f.Numerator /= n;
                f.Denominator /= n;
            }
        }
        //нахождение найбольшего общего делителя
        private  int MaxDiv()
        {
            int n = Numerator;
            int d = Denominator;
            int temp;
            while (d != 0)
            {
                temp = d;
                d = n % d;
                n = temp;
            }
            return n;
        }
        //создание Fraction из double
        private static Fraction DoubleToFractin(double d) {
            int n = 1;
            double temp = d;
            while (temp%1!= 0) {
                n *= 10;
                temp *= 10;
            }
            return new Fraction((int)(d*n), n);
        }
        //переопределение явного преобразования double в Fraction
        public static explicit operator Fraction(Double d) {
            return Fraction.DoubleToFractin(d);
        }
    }
}

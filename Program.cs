using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 4);           
            Fraction f3 = new Fraction(51, 50);           
            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");
            Console.WriteLine($"f3 = {f3}");
            Console.WriteLine($"f1+f2 = {f1+f2}");
            Console.WriteLine($"f1-f2 = {f1-f2}");
            Console.WriteLine($"f1*f2 = {f1*f2}");
            Console.WriteLine($"f1/f2 = {f1/f2}");
            Console.WriteLine($"f1==f2 = {f1==f2}");
            Console.WriteLine($"f1!=f2 = {f1!=f2}");
            if (f1)
            {
                Console.WriteLine($"Дробь f1 - {f1} правильная");
            }
            if (f3)
            {
                Console.WriteLine($"Дробь f3 - {f3} правильная");
            }
            else {
                Console.WriteLine($"Дробь f3 - {f3}  неправильная");
            }
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f4 = f * a;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"f*a = {f * a}");
            Fraction f5 = a*f;
            Console.WriteLine($"a*f = {a*f}");
            double d = 1.5;
            Console.WriteLine($"d = {d}");
            Fraction f6 = f + d;
            Console.WriteLine($"f+d = {f+d}");
        }
    }
}

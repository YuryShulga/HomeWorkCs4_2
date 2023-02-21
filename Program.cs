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
            Fraction f3 = new Fraction(5, 50);           
            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");
            Console.WriteLine($"f3 = {f3}");
            Console.WriteLine($"f1+f2 = {f1+f2}");
            Console.WriteLine($"1.5 = {(Fraction)1.55}");
            

            
        }
    }
}

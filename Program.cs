using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational test1 = new Rational(4, 16);
            Rational test2 = new Rational(15, 3);
            Rational r = test1 + test2;
            Console.WriteLine(r);
            Rational r2 = test1 - test2;
            Console.WriteLine(r2);
            bool b = test2 > test1;
            Console.WriteLine(b);
            bool d = test1 > test2;
            Console.WriteLine(d);
            Rational r3 = test1 * test2;
            Console.WriteLine(r3);

        }
    }
}

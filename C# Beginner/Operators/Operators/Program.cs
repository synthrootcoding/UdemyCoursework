using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a + b); // 13
            //Console.WriteLine((float)a / (float)b); // 3.33

            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a + b * c); // 7
            Console.WriteLine((a + b) * c); // 9
            Console.WriteLine(a > b); // False
            Console.WriteLine(a == b); // False
            Console.WriteLine(a != b); // True
            Console.WriteLine(!(a !=b)); // False
            Console.WriteLine(a == b); // False, same as above but easier to read
            Console.WriteLine(c > b && c > a); // True
            Console.WriteLine(c > b && c == a); // False
            Console.WriteLine(c > b || c == a); // True
            Console.WriteLine(!(c < b || c == a)); // True

            // Single-line comment

            /*
             * Multi-line comment
             */

            // Multi-line
            // Comment
        }
    }
}

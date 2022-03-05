using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction a = new fraction();
            fraction b = new fraction(1, 8);
            fraction c = new fraction(4, 8);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            

        }
    }
}

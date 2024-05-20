using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Numeric types

            // Integers
            int age = 20;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            // Long integer
            long b = 90000000L;
            Console.WriteLine(b);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            // Decimals
            // double
            double c = 55.20;
            Console.WriteLine(c);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            // float
            float f = 5.000001F;
            Console.WriteLine(f);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            // decimal -> money
            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FullCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hi {i}");
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

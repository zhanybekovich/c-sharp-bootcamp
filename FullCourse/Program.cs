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
            // while loop
            int age = 10;

            string result = age >= 0 ? "Valid" : "Invalid";

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

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
            // Operators
            int age = 23;
            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            age += 10;
            Console.WriteLine(age);

            age -= 5;
            Console.WriteLine(age);

            age *= 2;
            Console.WriteLine(age);

            
            double newAge = 35;
            newAge /= 3;
            Console.WriteLine(newAge);

            string text1 = "Hello";
            string text2 = "world";
            Console.WriteLine(text1 + text2);

            // Remainder operator
            int num1 = 10;
            int num2 = 3;
            Console.WriteLine(num1 % num2);

            Console.ReadLine();

        }
    }
}

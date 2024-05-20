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
            // If statement and logic operators
            // ==, >, >=, <, <=, !=
            // ||, &&

            int age = 20;

            /*if (age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            } else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older");
            }*/

            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age");
            } else
            {
                Console.WriteLine("Valid age");
            }*/

            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;

            Console.Write($"Value of {num1} * {num2} is: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            
            if (result == userAnswer)
            {
                Console.WriteLine("Well done!");
            } else
            {
                Console.WriteLine("Incorrect asnwer!");
            }

            Console.ReadLine();

        }
    }
}

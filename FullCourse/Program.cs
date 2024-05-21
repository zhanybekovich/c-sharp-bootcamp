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
            /*int i = 0;
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b  = Convert.ToInt32(Console.ReadLine());

            int answer = a * b;
            int actualAnswer = 0;

            Console.WriteLine($"What is the value of {a} * {b}?");

            while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                    Console.WriteLine("Try it again!");
                Console.WriteLine();
            }

            Console.WriteLine("Well Done!");*/

            // do while
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int answer = a * b;
            int actualAnswer = 0;

            Console.WriteLine($"What is the value of {a} * {b}?");

            do
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                    Console.WriteLine("Try it again!");
                Console.WriteLine();
            } while (answer != actualAnswer);

            Console.WriteLine("Well Done!");

            Console.ReadLine();
        }
    }
}

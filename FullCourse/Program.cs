﻿using System;
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
            // FizzBuz challenge
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }
    }
}

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
            // TryParse
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();

                // tries to convert 
                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            
            Console.ReadLine();
        }
    }
}

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
            // Convert string to number
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "900000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textFloat = "5.15";
            float floatNumber = Convert.ToSingle(textFloat, CultureInfo.InvariantCulture);
            Console.WriteLine(floatNumber);

            string textMoney = "6.99";
            decimal money = Convert.ToDecimal(textMoney, CultureInfo.InvariantCulture);
            Console.WriteLine(money);

            Console.ReadLine();

        }
    }
}

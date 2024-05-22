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
            // numeric formatting
            /*double value = 1000D / 12.34D;*/

            /*Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(value);*/

            double money = 10D / 3D;
            Console.WriteLine(string.Format("{0:0.00}", money));
            Console.WriteLine(money.ToString());

            // currency
            Console.WriteLine(money.ToString("C"));
            
            // truncate
            Console.WriteLine(money.ToString("C0"));
            
            // 1 decimal after .
            Console.WriteLine(money.ToString("C1"));

            // 2 decimal after .
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine("============");

            // Providing Culture info
            // Do not forget to add -> using System.Globalization;
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("ru")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("ky-KG")));

            Console.ReadLine();
        }
    }
}

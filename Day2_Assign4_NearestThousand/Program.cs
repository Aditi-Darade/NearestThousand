using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assign4_NearestThousand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1:
            /*
            System.Console.WriteLine("Enter a number: ");
            string stringNumber = System.Console.ReadLine();
            int number = int.Parse(stringNumber);

            string v = (number <= 1000) ? "1000" : (1000 < number & number < 1500) ? "1000" : (1500 <= number & number <= 2000) ? "2000" : (2000 < number & number < 2500) ? "2000" : (2500 <= number & number <= 3000) ? "3000" : "0";

            int nearestThousand = int.Parse(v);

            Console.WriteLine(nearestThousand);
            System.Console.ReadKey();
            */

            //Method 2:
            System.Console.WriteLine("Enter a number: ");
            string stringNumber = System.Console.ReadLine();
            int IntNumber = int.Parse(stringNumber);
            double DecNumber = Convert.ToDouble(stringNumber);

            int a = IntNumber / 1000 * 1000;
            System.Console.WriteLine("a = " + a);

            double b = (DecNumber / 1000 * 1000) - a ;
            System.Console.WriteLine("b = " + b);

            string v = (0 <= b & b < 500) ? "0" : (500 <= b & b < 1000) ? "1000" : "0";
            System.Console.WriteLine("v = " + v);
            
            double w = double.Parse(v);
            System.Console.WriteLine("w = " + w);

            System.Console.WriteLine("Nearest Thousandth:" + a + w);
            System.Console.ReadKey();
        }
    }
}

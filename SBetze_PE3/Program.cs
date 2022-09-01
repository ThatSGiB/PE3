using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBetze_PE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            numArray[0] = num1;
            Console.Write("Enter second number: ");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            numArray[1] = num2;
            Console.Write("Enter third number: ");
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);
            numArray[2] = num3;
            Console.Write("Enter fourth number: ");
            string str4 = Console.ReadLine();
            int num4 = Convert.ToInt32(str4);
            numArray[3] = num4;
            Console.WriteLine(numArray[0] + ", " + numArray[1] + ", " + numArray[2] + ", " + numArray[3]);
        }
    }
}

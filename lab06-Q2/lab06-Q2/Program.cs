using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for number 1:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for number 2:");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calObj = new Calculation();

            calObj.setValues(num1, num2);

            Console.WriteLine("Sum is: " + calObj.getAdd());
            Console.WriteLine("Sub is: " + calObj.getSub());
            Console.WriteLine("Multi is: " + calObj.getMulti());
            Console.WriteLine("Div is: " + calObj.getdiv());

        }
    }
}

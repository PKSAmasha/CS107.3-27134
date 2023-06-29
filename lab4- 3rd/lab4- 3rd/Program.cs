using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4__3rd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("methods;");
            Console.WriteLine("enter 1 for addition");
            Console.WriteLine("enter 2 for addition");
            Console.WriteLine("enter 3 for addition");
            Console.WriteLine("enter 4 for addition");

            Console.WriteLine("enter your choice:");

            string input = Console.ReadLine();

            Console.WriteLine("enter a value for a :");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("enter a value for b :");
            double b = double.Parse(Console.ReadLine());

            CalculateValue obj = new CalculateValue();
            double answer = 0;

            if (input == "1")
            {
                answer = obj.Sum(a, b);
            }
            else if (input == "2")
            {
                answer = obj.Sub(a, b);
            }
            else if (input == "3")
            {
                answer = obj.Multi(a, b);
            }
            else if (input == "4")
            {
                answer = obj.div(a, b);
            }
            Console.WriteLine("Answer is:" + answer);
            Console.ReadLine();
        }
    }
}

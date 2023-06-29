using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4__3rd
{
    internal class CalculateValue
    {
        public double
           Sum(double a, double b)
        {
            return a + b;
        }
        public double
             Sub(double a, double b)
        {
            return a - b;
        }
        public double
            Multi(double a, double b)
        {
            return a * b;
        }
        public double
            div(double a, double b)
        {
            if (a != 0)
                return a / b;
            else
            {
                Console.WriteLine("cannot divide by zero");
                return 0;
            }
        }
    }
}

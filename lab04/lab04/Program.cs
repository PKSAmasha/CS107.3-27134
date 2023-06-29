using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("enter the radius:");
                double radius = double.Parse(Console.ReadLine());

                FindValue findValue = new FindValue();
                double area = findValue.findArea(radius);
                Console.WriteLine("Area is:" + area);

                double circumference = findValue.findCircumference(radius);
                Console.WriteLine("Circumference is:" + circumference);
            
            
                Console.ReadKey();
        }
    }
}

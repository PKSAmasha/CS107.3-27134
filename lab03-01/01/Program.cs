using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            int sum = 0;

            for (int i = 0; i < 10; i++) //i < num.length; can also write like this
            {
                Console.Write("Enter a value: ");
                number[i] = int.Parse(Console.ReadLine()); 
            }
          
            for (int i = 0; i < 10; i++)
            {
                ;
                sum = sum + number[i];
            }

            Console.ReadKey();
        }
}

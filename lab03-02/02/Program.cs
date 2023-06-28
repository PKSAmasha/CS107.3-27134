using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 122, 45, 65, 49, 345, 21, 15, 945 };

            int smallest = num[0];
            int largest = num[0];

            for (int i = 1; i < num.Length; i++) 
            {
                if (smallest > num[i])
                {
                    smallest = num[i];
                }
                if ( largest < num[i] )
                {
                    largest = num[i];
                }

            }
            Console.WriteLine("smalest :" +smallest);
            Console.WriteLine("largest :" + largest);

            Console.ReadKey();
        }
    }
}

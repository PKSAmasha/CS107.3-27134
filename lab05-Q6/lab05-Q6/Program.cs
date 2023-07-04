using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            Array obj = new Array();
            int[] array = obj.ArrayMethod(size);

            Console.WriteLine("\n Display the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");

            }
                Console.ReadLine();
        }
    }
}

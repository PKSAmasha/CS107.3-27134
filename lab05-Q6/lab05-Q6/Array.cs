using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab05_Q6
{
    internal class Array
    {
        public int[] ArrayMethod(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine("Enter values for the array:");
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
                array[i + 1] = 0;
            }

            return array;

        }
    }
}



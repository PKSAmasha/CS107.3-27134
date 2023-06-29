using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = { { 10, 20 }, { 23,33} };

            int min = array2D[0,0];
            int max = array2D[0,0];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                     if (array2D[i,j] < min)
                      {
                        min = array2D[i, j];
                      }
                     if (array2D[i,j]>max)
                    {
                        max = array2D[i,j];
                    }

                }
            }
            Console.WriteLine(" min is :" + min);
            Console.WriteLine("min is :" + max);

        }
    }
}

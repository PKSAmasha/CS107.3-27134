using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter students mark:");
            int marks = Convert.ToInt32(Console.ReadLine());
            while (marks < 0 || marks >100)
            {

                Console.WriteLine("inavalid marks,Please try again:");
                marks = int.Parse(Console.ReadLine());
            }
            string grade;
            if (marks >= 75 && marks <= 100)
            {
                grade = "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "D";
            }
            else 
            {
                grade = "Fail";
            }
            
            Console.WriteLine("student name:" + name);
            Console.WriteLine("student grade:" + grade);
                Console.ReadLine();
           
        }
    }
}

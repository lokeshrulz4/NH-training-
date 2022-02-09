using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"fact of given number is:{fact}");


            Console.ReadLine();



        }
    }
}
        
   


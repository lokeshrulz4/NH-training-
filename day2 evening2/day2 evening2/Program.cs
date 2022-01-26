using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_evening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, fact = 1, number;
            Console.WriteLine("enter number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("factorial of" + number + " is :" + fact);
        }
    }
}
    
    
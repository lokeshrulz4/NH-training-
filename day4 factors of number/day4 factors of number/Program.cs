using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_factors_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("enter any number :");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++) 
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
        
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_assignment_on_facorial_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i, fact = 1;
            Console.WriteLine("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());
            getFact(input);
        }

        static void getFact(int input)
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial of a given number:" + fact);
            Console.ReadLine();
        }
    }


}


















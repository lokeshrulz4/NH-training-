using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_assignment_swapping_without_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
    }

}

        
    


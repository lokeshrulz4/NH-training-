using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_swapping_two_numbers_with_third_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3, temp;


            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
    }

}

       
    


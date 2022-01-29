using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_FIBANOCCI_SERIES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, n;
            Console.WriteLine("Enter number of fibnocci range n-2:");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0");
            Console.WriteLine("1");

            for (int i = 0; i < n - 2; i++)
            {

                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }


            Console.ReadLine();
        }


    }

}

       
   

